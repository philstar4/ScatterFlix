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
            XmlDocument doc = new XmlDocument();
            doc.Load(xmlFile);

            XmlNode movieListNode = doc.SelectSingleNode("movielist");
            XmlNodeList movieNodeList = movieListNode.SelectNodes("movie");

            foreach (XmlNode node in movieNodeList)
            {
                if (node.SelectSingleNode("title").InnerText.Trim() == movieName)
                {
                    // Single node attributes
                    lblMovieTitle.Text = node.SelectSingleNode("title").InnerText.Trim();
                    txtDirector.Text = node.SelectSingleNode("director").InnerText.Trim();
                    txtYear.Text = node.SelectSingleNode("year").InnerText.Trim();
                    txtRuntime.Text = node.SelectSingleNode("length").InnerText.Trim();

                    // Multi node attributes
                    txtSubgenres.Text = "";
                    foreach (XmlNode genreNode in node.SelectNodes("genre"))
                    {
                        if (count == 0)
                        {
                            txtGenre.Text = genreNode.InnerText.Trim();
                        }
                        else
                        {
                            txtSubgenres.Text += genreNode.InnerText.Trim() + ", ";
                        }

                        count++;
                    }

                    // Remove last comma and space at the end of subgenres
                    txtSubgenres.Text = txtSubgenres.Text.Remove(txtSubgenres.Text.Length - 2);

                    txtCast.Text = "";
                    foreach (XmlNode castNode in node.SelectNodes("actor"))
                    {
                        txtCast.Text += castNode.InnerText.Trim() + '\n';
                    }
                }
            }
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
