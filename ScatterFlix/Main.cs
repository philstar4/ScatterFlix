using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
                            currMovie.Title = attribute.Value;
                        }
                        else if (attribute.Name == "actor")
                        {
                            currMovie.addActor(attribute.Value);
                        }
                        else if (attribute.Name == "director")
                        {
                            currMovie.Director = attribute.Value;
                        }
                        else if (attribute.Name == "year")
                        {
                            currMovie.Year = Convert.ToInt32(attribute.Value);
                        }
                        else if (attribute.Name == "genre")
                        {
                            currMovie.addGenre(attribute.Value);
                        }
                        else if (attribute.Name == "rating")
                        {
                            currMovie.OverallRating = Convert.ToInt32(attribute.Value);
                        }
                        else if (attribute.Name == "watchlist")
                        {
                            currMovie.OnWatchList = Convert.ToBoolean(attribute.Value);
                        }
                        else if (attribute.Name == "userrating")
                        {
                            currMovie.UserRating = Convert.ToInt32(attribute.Value);
                        }
                        else if (attribute.Name == "length")
                        {
                            currMovie.Runtime = attribute.Value;
                        }
                    }
                    movies.Add(currMovie);
                }
            }

            movies.Sort((x, y) => x.Title.CompareTo(y.Title));
        }

        private void clearSearchFields()
        {
            watchListCheckBox.Checked = false;
            titleBox.Clear();
            actorBox.SelectedIndex = -1;
            actorBox.Text = "";
            directorBox.SelectedIndex = -1;
            directorBox.Text = "";
            yearBox.SelectedIndex = -1;
            yearBox.Text = "";
            genreBox.SelectedIndex = -1;
            genreBox.Text = "";
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
            DataPoint point;

            try
            {
                year = yearBox.Text != null ? Convert.ToInt32(yearBox.Text) : -1;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.StackTrace);
            }

            foreach (Movie movie in movies)
            {
                if (movie.containsTitle(title) && movie.hasActor(actor)
                    && movie.hasDirector(director) && movie.isFromYear(year)
                    && movie.isGenre(genre) && movie.meetsRating(rating) && movie.OnWatchList == watchlist)
                {
                    mainMoviesList.Items.Add(new ListViewItem(movie.Title));
                    point = new DataPoint(movie.Year, movie.OverallRating);
                    point.ToolTip = movie.Title;
                    movieScatter.Series[0].Points.Add(point);
                }
            }
        }

        private void prefsButton_Click(object sender, EventArgs e)
        {
            new Preferences().ShowDialog();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            mainMoviesList.Items.Clear();
            movieScatter.Series[0].Points.Clear();
            populateMovieList();
        }

        private void mainMoviesList_MovieDoubleClicked(object sender, EventArgs e)
        {
            Movie selectedMovie = movies.Find(movie => movie.Title.Trim() == mainMoviesList.SelectedItems[0].Text.Trim());
            new MovieDetailForm(selectedMovie).ShowDialog();
        }

        private void movieScatter_OnClick(object sender, MouseEventArgs e)
        {
            HitTestResult result = movieScatter.HitTest(e.X, e.Y);

            if (result.PointIndex >= 0)
            {
                DataPoint point = movieScatter.Series[0].Points[result.PointIndex];
                Movie selectedMovie = movies.Find(movie => movie.Title.Trim() == point.ToolTip.Trim());
                new MovieDetailForm(selectedMovie).ShowDialog();
            }
        }

        private void textBox_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                searchButton.PerformClick();
            }
        }
    }
}
