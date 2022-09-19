using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;


namespace UserModule
{
    public class Movie
    {
        public static int Stock;
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
        public int Movie_cost { get; set; }
        public DateTime runtime { get; set; }

        public DateTime Rental_Period { get; set; }

        public DateTime Delivered_Time { get; set; }

        public double addtotal { get; set; }

        public int Days_Rented { get; set; }

        public void Rent_Movie(List<Movie> movielist, List<Movie> Movie_Stock, int n, Admin A)
        {
            double addtotal = 0;
            Console.WriteLine("Press 1 to confirm \n 1.yes 2.No");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("The movies available for you are");
            foreach (Movie items in movielist)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                items.Rental_Period = new DateTime(2022, 9, 1);
                Console.Write(items.Movie_Name + " ");
                Console.Write(items.Lang + " ");
                Console.Write(items.Genre + " ");
                Console.WriteLine(items.Movie_cost + " ");
                Console.Write(items.runtime + " ");
                Console.WriteLine();
            }
            if (no == 1)
            {


                Console.ForegroundColor = ConsoleColor.DarkBlue;
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("Enter the {0} movie you want to add", i);
                    string search1 = Console.ReadLine();
                    Movie Searchedmovies1 = movielist.Find(x => x.Genre == search1 || x.Lang == search1 || x.Movie_Name
                == search1);
                    Movie_Stock.Add(Searchedmovies1);
                    movielist.Remove(Searchedmovies1);
                    Stock--;
                    Console.WriteLine("Enter how many days do you want for the Rent");
                    int days = int.Parse(Console.ReadLine());
                    Searchedmovies1.Days_Rented = days;
                    double price = (days * (0.10 * Searchedmovies1.Movie_cost) * (0.18 * Searchedmovies1.Movie_cost));
                    addtotal += price;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The total price of the CDs : Rs." + addtotal);
                foreach (var items in Movie_Stock)
                {
                    Console.WriteLine("The movies you rented are");
                    Console.Write(items.Movie_Name + " ");
                    Console.Write(items.Lang + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.runtime + " ");
                    Console.WriteLine();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available movies are " + Stock);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The movies available for you are");
                Console.WriteLine();
                foreach (Movie items in movielist)
                {

                    Console.Write(items.Movie_Name + " ");
                    Console.Write(items.Lang + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.runtime + " ");
                    Console.WriteLine();
                }
                A.Delivery(movielist, Movie_Stock);
            }
            else
            {
                Console.WriteLine("You cannot add these Movies");
            }

        }

        public void ReturnCD(List<Movie> movielist, List<Movie> Moviestock)
        {
            foreach (Movie items in Moviestock)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
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
                Console.WriteLine("Enter the movie you to be returned or cancelled");
                string mov = Console.ReadLine();
                Movie remove = Moviestock.Find(x => x.Movie_Name == mov);
                Moviestock.Remove(remove);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Movie returned sucessfully");
                foreach (Movie items in Moviestock)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("The movies you Rented are");
                    Console.Write(items.Movie_Name + " ");
                    Console.Write(items.Lang + " ");
                    Console.Write(items.Genre + " ");
                    Console.Write(items.runtime + " ");
                    Console.WriteLine();

                }
                movielist.Add(remove);
                Stock++;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("The Available stock of movies are " + Stock);
                Console.WriteLine();
                Console.WriteLine("The movies available for you are");
                Console.WriteLine();
                foreach (Movie items in movielist)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

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




    }

    public class Users
    {
        public string User_name { get; set; }
        public string Passwd { get; set; }

        private string _phno;

        public string Phone_num
        {
            get { return _phno; }
            set { _phno = value; }
        }
        public DateTime Date_Added { get; set; }

        private List<Movie> _moviestock;

        public List<Movie> MovieStock
        {
            get { return _moviestock; }
            set
            {
                if (MovieStock.Count >= 5) { _moviestock = value; }
                else
                {
                    Console.WriteLine("No more rental is allowed if the limit is reached");
                }
            }
        }

        public enum Badge
        {
            Silver = 2,
            Gold = 3,
            Platinum = 5
        }
        public void SearchByLangOrGenre(List<Movie> movielist)
        {
            Console.WriteLine("Genre :- \n 1. Romance \n 2.Action \n 3.Documentary \n 4.Sci-fi \n 5.Drama \n 6.Thriller \n 7.Fantasy" +
                "\n 7.History");
            Console.WriteLine("Languages :- \n 1.Tamil \n 2.English \n 3.Hindi \n 4.Telugu");
            Console.WriteLine("Enter the language or genre to search the movies");
            string search = Console.ReadLine();
            List<Movie> Searchedmovies = movielist.FindAll(x => x.Genre == search || x.Lang == search);
            if (Searchedmovies.Count > 0)
            {
                foreach (Movie movie in Searchedmovies)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(movie.Movie_Name);
                    Console.WriteLine(movie.Genre);
                    Console.WriteLine(movie.Lang);
                    Console.WriteLine("****************************************");
                }

            }
            else
            {
                Console.WriteLine("Movie/Genre not found. " +
                    "Sorry for the inconvenience");
            }


        }

        public void Renting(List<Movie> movielist, Users Pass)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose the kind of subscription you need \n Options:-\n Press 1 for Silver Subscription - 2 Movies can be rented" +
                " \n Press 2 Gold Subscription - 3 Movies can be Rented \n Press 3 for Platinum Subscription - 5 Movies can be Rented \n "
                );
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Admin admin = new Admin();
                        admin.Adminapproval(movielist, Pass, (int)Users.Badge.Silver, admin);
                        break;
                    }
                case 2:
                    {
                        Admin admin = new Admin();
                        admin.Adminapproval(movielist, Pass, (int)Users.Badge.Gold, admin);
                        break;
                    }
                case 3:
                    {
                        Admin admin = new Admin();
                        admin.Adminapproval(movielist, Pass, (int)Users.Badge.Platinum, admin);
                        break;
                    }
            }
        }
    }
}