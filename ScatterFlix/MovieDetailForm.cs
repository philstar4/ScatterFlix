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
        string xmlFile = Path.Combine(System.Windows.Forms.Application.StartupPath, "movies.xml");
        XmlDocument moviesXml;
        XmlNode movieNode;

        public MovieDetailForm(string movieName)
        {
            InitializeComponent();
            loadData(movieName);
            loadMoviePoster(movieName);
        }

        private void loadMoviePoster(string movieName)
        {
            string movieParam = movieName.Replace(' ', '+');
            string endpoint = @"http://www.omdbapi.com/";
            var client = new RestClient(endpoint);
            var json = client.MakeRequest("?t=" + movieParam + "&y=&plot=short&r=json");
            dynamic data = JObject.Parse(json);
            imgMoviePoster.ImageLocation = data.Poster;
        }

        private void loadData(string movieName)
        {
            int count = 0;
            bool addedSubgenre = false;

            moviesXml = new XmlDocument();
            moviesXml.Load(xmlFile);

            XmlNode movieListNode = moviesXml.SelectSingleNode("movielist");
            XmlNodeList movieNodeList = movieListNode.SelectNodes("movie");

            foreach (XmlNode node in movieNodeList)
            {
                if (node.SelectSingleNode("title").InnerText.Trim() == movieName.Trim())
                {
                    movieNode = node;

                    // Single node attributes
                    lblMovieTitle.Text = movieNode.SelectSingleNode("title").InnerText.Trim();
                    txtDirector.Text = movieNode.SelectSingleNode("director").InnerText.Trim();
                    txtYear.Text = movieNode.SelectSingleNode("year").InnerText.Trim();
                    txtRuntime.Text = movieNode.SelectSingleNode("length").InnerText.Trim();
                    tbOverallRating.Value = Convert.ToInt32(movieNode.SelectSingleNode("rating").InnerText.Trim());
                    lblOverallRatingDetail.Text = movieNode.SelectSingleNode("rating").InnerText.Trim() + "/10";
                    tbYourRating.Value = Convert.ToInt32(movieNode.SelectSingleNode("userrating").InnerText.Trim());
                    lblYourRatingDetail.Text = movieNode.SelectSingleNode("userrating").InnerText.Trim() + "/10";
                    btnWatchList.Text = setWatchListButtonText(Convert.ToBoolean(movieNode.SelectSingleNode("watchlist").InnerText.Trim()));

                    // Multi node attributes
                    txtSubgenres.Text = "";
                    foreach (XmlNode genreNode in movieNode.SelectNodes("genre"))
                    {
                        if (count == 0)
                        {
                            txtGenre.Text = genreNode.InnerText.Trim();
                        }
                        else
                        {
                            txtSubgenres.Text += genreNode.InnerText.Trim() + ", ";
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
                    foreach (XmlNode castNode in movieNode.SelectNodes("actor"))
                    {
                        txtCast.Text += castNode.InnerText.Trim() + '\n';
                    }
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

            movieNode.SelectSingleNode("userrating").InnerText = tbYourRating.Value.ToString();
            moviesXml.Save(xmlFile);
        }

        private void btnWatchList_Click(object sender, EventArgs e)
        {
            bool onWatchList = Convert.ToBoolean(movieNode.SelectSingleNode("watchlist").InnerText);
            onWatchList = !onWatchList;

            btnWatchList.Text = setWatchListButtonText(onWatchList);
            movieNode.SelectSingleNode("watchlist").InnerText = onWatchList.ToString();
            moviesXml.Save(xmlFile);
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
