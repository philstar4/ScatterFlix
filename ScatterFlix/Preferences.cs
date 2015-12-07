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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadData()
        {
            XDocument moviesXml = XDocument.Load(moviesXmlFile);

            //populate the form options
            foreach(XElement table in moviesXml.Elements())
            {
                foreach(XElement row in table.Nodes())
                {
                    foreach(XElement attribute in row.Nodes())
                    {
                        switch(attribute.Name.ToString())
                        {
                            case "actor":
                                if(!actorBox.Items.Contains(attribute.Value.ToString()))
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
    }
}
