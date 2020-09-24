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





        //Override To String, because the Tree is Generic
        public override string ToString()
        {
            string ValText = string.Format("{0,25}", Director) + "|" + $"{ImdbRating:000000;-00000}" + "|" + string.Format("{0,25}", Genre) + "|" + string.Format("{0,15}", ReleaseDate) + "|" + $"{RottenTomatoesRating:000000;-00000}" + "|" + string.Format("{0,50}", Title);
            return ValText;
        }
        //Get size Model
        public int TamVal()
        {
            return 132;
        }
        public static Func<string, mMovie> GetMovie = delegate (string data)
                {
                    string[] contenedor = data.Split("|");
                    int[] tamValues = new int[6] { 25, 6, 25, 15, 6, 50 };
                    string[] aux = new string[6];
                    int pos = 0;
                    for(int i=0; i<aux.Length;i++)
                        {
                        aux[i] = contenedor[pos];
                        while (aux[i].Length!=tamValues[i])
                        {
                            aux[i] += "|" + contenedor[pos];
                        }
                    }
                    mMovie peli = new mMovie() {
                        Director = aux[0].Trim(),
                        ImdbRating = double.Parse(aux[1]),
                        Genre = aux[2].Trim(),
                        ReleaseDate= aux[3].Trim(),
                        RottenTomatoesRating= int.Parse(aux[4].Trim()),
                         Title= aux[5].Trim()
                    };
                    return peli;
                };
   
    }
}
