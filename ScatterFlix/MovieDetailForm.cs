using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ScatterFlix
{
    public partial class MovieDetailForm : Form
    {
        Movie movie;
        string xmlFile = Path.Combine(System.Windows.Forms.Application.StartupPath, "movies.xml");
        XmlDocument moviesXml;
        XmlNode movieNode;

        public MovieDetailForm(Movie movie)
        {
            InitializeComponent();
            this.movie = movie;
            loadData();
            loadMoviePoster();
            loadXml();
        }

        private void loadMoviePoster()
        {
            string movieParam = movie.Title.Replace(' ', '+');
            string endpoint = @"http://www.omdbapi.com/";
            var client = new RestClient(endpoint);
            var json = client.MakeRequest("?t=" + movieParam + "&y=&plot=short&r=json");
            dynamic data = JObject.Parse(json);
            imgMoviePoster.ImageLocation = data.Poster;
        }

        private void loadData()
        {
            int count = 0;
            bool addedSubgenre = false;

            // Single node attributes
            lblMovieTitle.Text = movie.Title.Trim();
            txtDirector.Text = movie.Director.Trim();
            txtYear.Text = movie.Year.ToString();
            txtRuntime.Text = movie.Runtime.Trim();
            tbOverallRating.Value = movie.OverallRating;
            lblOverallRatingDetail.Text = movie.OverallRating.ToString() + "/10";
            tbYourRating.Value = movie.UserRating;
            lblYourRatingDetail.Text = movie.UserRating.ToString() + "/10";
            btnWatchList.Text = setWatchListButtonText(movie.OnWatchList);

            // Multi node attributes
            txtSubgenres.Text = "";
            foreach (String genre in movie.Genres)
            {
                if (count == 0)
                {
                    txtGenre.Text = genre.Trim();
                }
                else
                {
                    txtSubgenres.Text += genre.Trim() + ", ";
                    addedSubgenre = true;
                }

                count++;
            }

            // Remove last comma and space at the end of subgenres
            if (addedSubgenre)
            {
                txtSubgenres.Text = txtSubgenres.Text.Remove(txtSubgenres.Text.Length - 2);
            }

            txtCast.Text = "";
            foreach (String actor in movie.Actors)
            {
                txtCast.Text += actor.Trim() + '\n';
            }
        }

        private void loadXml()
        {
            moviesXml = new XmlDocument();
            moviesXml.Load(xmlFile);

            XmlNode movieListNode = moviesXml.SelectSingleNode("movielist");
            XmlNodeList movieNodeList = movieListNode.SelectNodes("movie");

            foreach (XmlNode node in movieNodeList)
            {
                if (node.SelectSingleNode("title").InnerText.Trim() == movie.Title.Trim())
                {
                    movieNode = node;
                }
            }
        }

        private string setWatchListButtonText(bool onWatchList)
        {
            if (onWatchList)
            {
               return "Remove From Watch List";
            }
            else
            {
                return "Add To Watch List";
            }
        }

        private void tbYourRating_Scroll(object sender, EventArgs e)
        {
            lblYourRatingDetail.Text = tbYourRating.Value + "/10";

            movie.UserRating = tbYourRating.Value;
            movieNode.SelectSingleNode("userrating").InnerText = movie.UserRating.ToString();
            moviesXml.Save(xmlFile);
        }

        private void btnWatchList_Click(object sender, EventArgs e)
        {
            movie.OnWatchList = !movie.OnWatchList;

            btnWatchList.Text = setWatchListButtonText(movie.OnWatchList);
            movieNode.SelectSingleNode("watchlist").InnerText = movie.OnWatchList.ToString();
            moviesXml.Save(xmlFile);
        }

        private void MovieDetailForm_Load(object sender, EventArgs e)
        {
            this.Text = movie.Title.Trim() + " (" + movie.Year.ToString() + ")";
        }
    }

    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }

    public class RestClient
    {
        public string EndPoint { get; set; }
        public HttpVerb Method { get; set; }
        public string ContentType { get; set; }
        public string PostData { get; set; }

        public RestClient()
        {
            EndPoint = "";
            Method = HttpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }
        public RestClient(string endpoint)
        {
            EndPoint = endpoint;
            Method = HttpVerb.GET;
            ContentType = "text/xml";
            PostData = "";
        }
        public RestClient(string endpoint, HttpVerb method)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/xml";
            PostData = "";
        }

        public RestClient(string endpoint, HttpVerb method, string postData)
        {
            EndPoint = endpoint;
            Method = method;
            ContentType = "text/xml";
            PostData = postData;
        }


        public string MakeRequest()
        {
            return MakeRequest("");
        }

        public string MakeRequest(string parameters)
        {
            var request = (HttpWebRequest)WebRequest.Create(EndPoint + parameters);

            request.Method = Method.ToString();
            request.ContentLength = 0;
            request.ContentType = ContentType;

            if (!string.IsNullOrEmpty(PostData) && Method == HttpVerb.POST)
            {
                var encoding = new UTF8Encoding();
                var bytes = Encoding.GetEncoding("iso-8859-1").GetBytes(PostData);
                request.ContentLength = bytes.Length;

                using (var writeStream = request.GetRequestStream())
                {
                    writeStream.Write(bytes, 0, bytes.Length);
                }
            }

            using (var response = (HttpWebResponse)request.GetResponse())
            {
                var responseValue = string.Empty;

                if (response.StatusCode != HttpStatusCode.OK)
                {
                    var message = String.Format("Request failed. Received HTTP {0}", response.StatusCode);
                    throw new ApplicationException(message);
                }

                // grab the response
                using (var responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                        using (var reader = new StreamReader(responseStream))
                        {
                            responseValue = reader.ReadToEnd();
                        }
                }

                return responseValue;
            }
        }
    }
}
