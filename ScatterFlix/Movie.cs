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
        private bool isWatched;

        public Movie()
        {
            actors = new List<String>();
            genres = new List<String>();
        }

        public void addTitle(String title)
        {
            this.title = title;
        }

        public String getTitle()
        {
            return title;
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
            return actors.Contains(actor);
        }

        public void addDirector(String director)
        {
            this.director = director;
        }

        public bool hasDirector(String director)
        {
            if (director == "")
            {
                return true;
            }
            return this.director == director;
        }

        public void addYear(int year)
        {
            this.year = year;
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

        public void addRating(int rating)
        {
            this.rating = rating;
        }

        public bool meetsRating(int rating)
        {
            if (rating == 0)
            {
                return true;
            }
            return this.rating >= rating;
        }

        public void setWatched(bool watched)
        {
            isWatched = watched;
        }

        public bool isOnWatchList(bool watchlist)
        {
            return watchlist == isWatched;
        }
    }
}
