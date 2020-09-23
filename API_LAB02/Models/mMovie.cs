using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_LAB02.Models
{
    public class mMovie
    {
        private string director;
        private double imdbRating;
        private string genre;
        private string releaseDate;
        private int rottenTomatoesRating;
        private string title;

        public string Director { get => director; set => director = value; }
        public double ImdbRating { get => imdbRating; set => imdbRating = value; }
        public string Genre { get => genre; set => genre = value; }
        public string ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public int RottenTomatoesRating { get => rottenTomatoesRating; set => rottenTomatoesRating = value; }
        public string Title { get => title; set => title = value; }
  
        public int CompareTo(object obj)
        {
            try
            {
                var Movie = (mMovie)obj;
                if (Title.CompareTo(Movie.Title) != 0)
                {
                    return Title.CompareTo(Movie.title);
                }
                else if (ReleaseDate.CompareTo(Movie.ReleaseDate) != 0)
                {
                    return ReleaseDate.CompareTo(Movie.ReleaseDate);
                }
                else if (RottenTomatoesRating.CompareTo(Movie.RottenTomatoesRating) != 0)
                {
                    return RottenTomatoesRating.CompareTo(Movie.RottenTomatoesRating);
                }
                return 0;
            }
            catch
            {
                return 0;
            }
        }



    }
}
