using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScatterFlix
{
    class Movie
    {
        private String title;
        private List<String> actors;
        private String director;
        private int year;
        private List<String> genres;
        private int rating;
        private bool onWatchList;

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
            return this.title.Contains(title);
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
                    if (currActor.Contains(actor))
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
            return this.director.Contains(director);
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
            return genres.Contains(genre);
        }

        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }

        public bool meetsRating(int rating)
        {
            if (rating == 0)
            {
                return true;
            }
            return this.rating >= rating;
        }

        public bool OnWatchList
        {
            get { return onWatchList; }
            set { onWatchList = value; }
        }
    }
}
