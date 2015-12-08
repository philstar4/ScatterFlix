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
using System.Xml.Linq;

namespace ScatterFlix
{
    public partial class Preferences : Form
    {
        string moviesXmlFile = Path.Combine(System.Windows.Forms.Application.StartupPath, "movies.xml");
        string prefsXmlFile = Path.Combine(System.Windows.Forms.Application.StartupPath, "prefs.xml");

        public Preferences()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            loadFormOptions();
            loadCurrentPreferences();
        }

        private void loadFormOptions()
        {
            XDocument moviesXml = XDocument.Load("movies.xml");

            foreach (XElement table in moviesXml.Elements())
            {
                foreach (XElement row in table.Nodes())
                {
                    foreach (XElement attribute in row.Nodes())
                    {
                        switch (attribute.Name.ToString())
                        {
                            case "actor":
                                if (!actorBox.Items.Contains(attribute.Value.ToString()))
                                {
                                    actorBox.Items.Add(attribute.Value.ToString());
                                }
                                break;
                            case "director":
                                if (!directorBox.Items.Contains(attribute.Value.ToString()))
                                {
                                    directorBox.Items.Add(attribute.Value.ToString());
                                }
                                break;
                            case "year":
                                if (!yearBox.Items.Contains(attribute.Value.ToString()))
                                {
                                    yearBox.Items.Add(attribute.Value.ToString());
                                }
                                break;
                            case "genre":
                                if (!genreBox.Items.Contains(attribute.Value.ToString()))
                                {
                                    genreBox.Items.Add(attribute.Value.ToString());
                                }
                                break;
                        }
                    }
                }
            }
        }

        private void loadCurrentPreferences()
        {
            XDocument prefsXml = XDocument.Load("prefs.xml");

            foreach (XElement table in prefsXml.Elements())
            {
                foreach (XElement row in table.Nodes())
                {
                    foreach (XElement attribute in row.Nodes())
                    {
                        switch (attribute.Name.ToString())
                        {
                            case "title":
                                titleBox.Text = attribute.Value.ToString();
                                break;
                            case "actor":
                                actorBox.SelectedIndex = actorBox.Items.IndexOf(attribute.Value.ToString());
                                break;
                            case "director":
                                directorBox.SelectedIndex = directorBox.Items.IndexOf(attribute.Value.ToString());
                                break;
                            case "year":
                                yearBox.SelectedIndex = yearBox.Items.IndexOf(attribute.Value.ToString());
                                break;
                            case "genre":
                                genreBox.SelectedIndex = genreBox.Items.IndexOf(attribute.Value.ToString());
                                break;
                            case "rating":
                                try
                                {
                                    ratingSlider.Value = Int32.Parse(attribute.Value);
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine(e.ToString());
                                }
                                break;
                        }
                    }
                }
            }
        }

        public virtual void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void okButton_Click(object sender, EventArgs e)
        {
            deleteOriginalPreferences();
            addNewPreferences();
            this.Close();
        }

        private void deleteOriginalPreferences()
        {
            XDocument doc = XDocument.Load(prefsXmlFile);

            doc.Descendants("preference").Remove();

            doc.Save(prefsXmlFile);
        }

        private void addNewPreferences()
        {
            XDocument doc = XDocument.Load(prefsXmlFile);
            XElement root = new XElement("preference");

            root.Add(new XElement("title", titleBox.Text.ToString()));
            root.Add(new XElement("actor", actorBox.Text.ToString()));
            root.Add(new XElement("director", directorBox.Text.ToString()));
            root.Add(new XElement("year", yearBox.Text.ToString()));
            root.Add(new XElement("genre", genreBox.Text.ToString()));
            root.Add(new XElement("rating", ratingSlider.Value.ToString()));

            doc.Element("preferences").Add(root);
            doc.Save(prefsXmlFile);
        }
    }
}
