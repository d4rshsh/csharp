using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    [Serializable()]
    public class Movie
    {
        public static int Available_Stock;
        private string _movieName;

        public string Movie_Name
        {
            get { return _movieName; }
            set { _movieName = value; }
        }

        private string _genre;

        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        private string _language;

        public string Lang
        {
            get { return _language; }
            set { _language = value; }
        }
        public int Price { get; set; }

        public DateTime runtime { get; set; }

        public DateTime RentedTime { get; set; }

        public double Movie_cost { get; set; }

        public void RentMovie(List<Movie> movie_list, List<Movie> Movie_stock)
        {
            double addtotal = 0;
            Console.WriteLine("Confirm \n 1.yes 2.No");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("The movies available for you are");
            foreach (Movie items in movie_list)
            {

                Console.Write(items.Movie_Name + " ");
                Console.Write(items.Lang + " ");
                Console.Write(items.Genre + " ");
                Console.WriteLine(items.Price + " ");
                Console.Write(items.runtime + " ");
                Console.WriteLine();
            }
            if (no == 1)
            {

                Console.WriteLine("Enter the number of movies to Rent");
                int n = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Yellow;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter the {0} movie you want to add", i);
                    string search1 = Console.ReadLine();
                    Movie mov1 = movie_list.Find(x => x.Genre == search1 || x.Lang == search1 || x.Movie_Name
                == search1);
                    Movie_stock.Add(mov1);
                    movie_list.Remove(mov1);
                    Available_Stock--;
                    Console.WriteLine("Enter number of days for rent:");
                    int days = int.Parse(Console.ReadLine());
                    double price = (days * (0.10 * mov1.Price) * (0.18 * mov1.Price));
                    addtotal += price;
                }
                
                Console.WriteLine("The total price of the CDs : Rs." + addtotal);
                foreach (var items in Movie_stock)
                {
                    Console.WriteLine("The movies you rented are");
                    Console.Write(items.Movie_Name + " ");
                    Console.Write(items.Lang + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.runtime + " ");
                    Console.WriteLine();
                }
                Console.WriteLine("The Available stock of movies are " + Available_Stock);
                Console.WriteLine("The movies available for you are");
                Console.WriteLine();
                foreach (Movie items in movie_list)
                {

                    Console.Write(items.Movie_Name + " ");
                    Console.Write(items.Lang + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.runtime + " ");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("These Movies can't be added");
            }

        }

        public void ReturnMovie(List<Movie> movie_list, List<Movie> Movie_stock)
        {
            foreach (Movie items in Movie_stock)
            {
                Console.WriteLine("The movies you Rented are");
                Console.Write(items.Movie_Name + " ");
                Console.Write(items.Lang + " ");
                Console.Write(items.Genre + " ");
                Console.Write(items.runtime + " ");
                Console.WriteLine();
            }
            char op = 'Y';
            while (op == 'Y')
            {
                Console.WriteLine("Enter the movie name you want to return");
                string mov = Console.ReadLine();
                Movie remove = Movie_stock.Find(x => x.Movie_Name == mov);
                Movie_stock.Remove(remove);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movie returned sucessfully");
                foreach (Movie items in Movie_stock)
                {
                    Console.WriteLine("The movies you Rented are");
                    Console.Write(items.Movie_Name + " ");
                    Console.Write(items.Lang + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.runtime + " ");
                    Console.WriteLine();

                }
                movie_list.Add(remove);
                Available_Stock++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available stock of movies are " + Available_Stock);
                Console.WriteLine();
                Console.WriteLine("The movies available for you are");
                Console.WriteLine();
                foreach (Movie items in movie_list)
                {

                    Console.Write(items.Movie_Name + " ");
                    Console.Write(items.Lang + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.runtime + " ");
                    Console.WriteLine();
                }
                Console.Write("Do you want to return another movie (Y/N) ? ");
                char an = Convert.ToChar(Console.ReadLine());
                if (an == 'Y' || an == 'y')
                {
                    op = 'Y';
                }
                else
                {
                    break;
                }

            }



        }
        public double Amount(Movie movie)
        {

            Console.WriteLine("Enter the Number of the days to rent the film");
            int day = int.Parse(Console.ReadLine());
            movie.Movie_cost = (day * (0.10 * movie.Price) * (0.18 * movie.Price));
            movie.RentedTime = DateTime.Now;
            Console.WriteLine("rented amount :" + movie.Movie_cost + " at " + movie.RentedTime);
            return movie.Movie_cost;
        }



    }
}