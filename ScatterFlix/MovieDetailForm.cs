using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
}
