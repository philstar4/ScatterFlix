using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScatterFlix
{
    public class Movie
    {
        private String title;
        private List<String> actors;
        private String director;
        private int year;
        private List<String> genres;
        private int overallRating;
        private int userRating;
        private bool onWatchList;
        private String runtime;

        public Movie()
        {
            actors = new List<String>();
            genres = new List<String>();
        }

        public String Title
        {
            get { return title; }
            set { title = value; }
        }

        public bool containsTitle(String title)
        {
            if(title == "")
            {
                return true;
            }
            return this.title.ToLower().Contains(title.ToLower());
        }

        public List<String> Actors
        {
            get { return actors; }
            set { actors = value; }
        }

        public void addActor(String actor)
        {
            actors.Add(actor);
        }

        public bool hasActor(String actor)
        {
            if(actor == "")
            {
                return true;
            }
            else
            {
                bool found = false;

                foreach (string currActor in actors)
                {
                    if (currActor.ToLower().Contains(actor.ToLower()))
                    {
                        found = true;
                    }
                }

                return found;
            }
        }

        public String Director
        {
            get { return director; }
            set { director = value; }
        }

        public bool hasDirector(String director)
        {
            if (director == "")
            {
                return true;
            }
            return this.director.ToLower().Contains(director.ToLower());
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public bool isFromYear(int year)
        {
            if (year == -1)
            {
                return true;
            }
            return this.year == year;
        }

        public List<String> Genres
        {
            get { return genres; }
            set { genres = value; }
        }

        public void addGenre(String genre)
        {
            genres.Add(genre);
        }

        public bool isGenre(String genre)
        {
            if (genre == "")
            {
                return true;
            }
            else
            {
                bool found = false;

                foreach (string currGenre in genres)
                {
                    if (currGenre.ToLower().Contains(genre.ToLower()))
                    {
                        found = true;
                    }
                }

                return found;
            }
        }

        public int OverallRating
        {
            get { return overallRating; }
            set { overallRating = value; }
        }

        public bool meetsRating(int rating)
        {
            if (rating == 0)
            {
                return true;
            }
            return this.overallRating >= rating;
        }

        public int UserRating
        {
            get { return userRating; }
            set { userRating = value; }
        }

        public bool OnWatchList
        {
            get { return onWatchList; }
            set { onWatchList = value; }
        }

        public String Runtime
        {
            get { return runtime; }
            set { runtime = value; }
        }
    }
}
