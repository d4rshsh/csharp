using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    public class MovieConst
    {
        public static int NumOfMovies = 0;
        public MovieConst()
        {
            this.Availability = 10;
        }
        public MovieConst(string Movie_Name, string Lang, string genre, double Cost)
        {
            this.Availability = 10;
            this.Movie_Name = Movie_Name;
            this.Lang = Lang;
            this.genres = genre;
            this.Cost = Cost;
            NumOfMovies++;
            movies_list.Add(this);
        }
        public static List<MovieConst> movies_list = new List<MovieConst>();
        private string _movieName;

        public string Movie_Name
        {
            get { return _movieName; }
            set { _movieName = value; }
        }

        private int _availability;

        public int Availability
        {
            get { return _availability; }
            set { _availability = value; }
        }
        private string _language;

        public string Lang
        {
            get { return _language; }
            set { _language = value; }
        }

        private string _genres;

        public string genres
        {
            get { return _genres; }
            set { _genres = value; }
        }
        private double _cost;

        public double Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        //public void AddMovies(MovieConst s)
        //{
        //	movies_list.Add(s);

        //}
        public void AddMovieDetails(string MovieName, string Language, string genres, double Cost)
        {
            //this.Availability = 10;
            this.Movie_Name = MovieName;
            this.Lang = Language;
            this.genres = genres;
            this.Cost = Cost;
            movies_list.Add(this);
            NumOfMovies++;
        }
        public static void PrintAllMovies()
        {
            foreach (var item in movies_list)
            {
                Console.WriteLine(item.Movie_Name);
            }
        }

    }
}