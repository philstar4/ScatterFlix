using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ScatterFlix
{
    public partial class Main : Preferences
    {
        List<Movie> movies = new List<Movie>();

        public Main()
        {
            InitializeComponent();
            storeMovies();
            populateMovieList();
        }

        public override void cancelButton_Click(object sender, EventArgs e)
        {
            clearSearchFields();
        }

        private void storeMovies()
        {
            XDocument moviesXml = XDocument.Load("movies.xml");

            foreach (XElement table in moviesXml.Elements())
            {
                foreach (XElement row in table.Nodes())
                {
                    Movie currMovie = new Movie();
                    foreach (XElement attribute in row.Nodes())
                    {
                        if (attribute.Name == "title")
                        {
                            currMovie.addTitle(attribute.Value);
                        }
                        else if (attribute.Name == "actor")
                        {
                            currMovie.addActor(attribute.Value);
                        }
                        else if (attribute.Name == "director")
                        {
                            currMovie.addDirector(attribute.Value);
                        }
                        else if (attribute.Name == "year")
                        {
                            currMovie.addYear(Int32.Parse(attribute.Value));
                        }
                        else if (attribute.Name == "genre")
                        {
                            currMovie.addGenre(attribute.Value);
                        }
                        else if (attribute.Name == "rating")
                        {
                            currMovie.addRating(Int32.Parse(attribute.Value));
                        }
                        else if (attribute.Name == "watchlist")
                        {
                            currMovie.setWatched(Convert.ToBoolean(attribute.Value));
                        }
                    }
                    movies.Add(currMovie);
                }
            }

            movies.Sort((x, y) => x.getTitle().CompareTo(y.getTitle()));
        }

        private void clearSearchFields()
        {
            watchListCheckBox.Checked = false;
            titleBox.Clear();
            actorBox.SelectedIndex = -1;
            directorBox.SelectedIndex = -1;
            yearBox.SelectedIndex = -1;
            genreBox.SelectedIndex = -1;
            ratingSlider.Value = 0;
        }

        private bool fieldsEmpty()
        {
            if((titleBox.Text == "") && (actorBox.SelectedIndex == -1) 
                && (directorBox.SelectedIndex == -1) && (yearBox.SelectedIndex == -1) 
                && (genreBox.SelectedIndex == -1) && (ratingSlider.Value == 0))
            {
                return true;
            }
            return false;
        }

        private void populateMovieList()
        {
            String title = titleBox.Text;
            String actor = actorBox.Text != null ? actorBox.Text : "";
            String director = directorBox.Text != null ? directorBox.Text : "";
            int year = -1;
            String genre = genreBox.Text != null ? genreBox.Text : "";
            int rating = ratingSlider.Value;
            bool watchlist = watchListCheckBox.Checked;

            try
            {
                year = yearBox.Text != null ? Convert.ToInt32(yearBox.Text) : -1;
            }
            catch (FormatException e)
            {

            }

            foreach (Movie movie in movies)
            {
                if (movie.containsTitle(title) && movie.hasActor(actor)
                    && movie.hasDirector(director) && movie.isFromYear(year)
                    && movie.isGenre(genre) && movie.meetsRating(rating) && movie.isOnWatchList(watchlist))
                {
                    mainMoviesList.Items.Add(new ListViewItem(movie.getTitle()));
                }
            }
            Console.WriteLine("finished");
        }

        private void prefsButton_Click(object sender, EventArgs e)
        {
            new Preferences().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainMoviesList.Items.Clear();
            populateMovieList();
        }

        private void mainMoviesList_MovieDoubleClicked(object sender, EventArgs e)
        {
            new MovieDetailForm(mainMoviesList.SelectedItems[0].Text).ShowDialog();
        }
    }
}
