using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Admin
    {
        private List<Users> _userslist;

        public List<Users> UsersList
        {
            get { return _userslist; }
            set { _userslist = value; }
        }


        public void Adminapproval(List<Movie> movielist, Users user, int n, Admin A)
        {
            Console.WriteLine("Confirm subscription \n Press 1 to confirm \n Press 2 to cancel");
            int no = int.Parse(Console.ReadLine());
            if (no == 1)
            {
                List<Movie> Moviestock = new List<Movie>();
                Movie sample = new Movie(); char op = 'y';
                while (op == 'y')
                {

                    Console.WriteLine("Hello Subscriber! Press \n 1 to Rent Movie \n 2 to Return Movie");
                    int Choice = int.Parse(Console.ReadLine());
                    switch (Choice)
                    {

                        case 1:
                            {

                                sample.Rent_Movie(movielist, Moviestock, n, A);


                                break;
                            }
                        case 2:
                            {
                                sample.ReturnCD(movielist, Moviestock);
                                break;
                            }
                    }
                    Console.Write("Do you want to continue (Y/N) ? ");
                    char an = Convert.ToChar(Console.ReadLine());
                    if (an == 'Y' || an == 'y')
                    {
                        op = 'y';
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
        public void Delivery(List<Movie> movielist, List<Movie> Moviestock)
        {

            Console.WriteLine("To be delivered soon");
            foreach (Movie movie in Moviestock.ToList())
            {
                List<Movie> OutstandingMovie = new List<Movie>();
                if ((DateTime.Now.Day - movie.Rental_Period.Day) > 10)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Delay more than 10 days");
                    Console.WriteLine("Do you want to cancel the movie Y/N ?");
                    Console.WriteLine(movie.Movie_Name + "cancelled");
                    char ch = Convert.ToChar(Console.ReadLine());
                    if (ch == 'Y' || ch == 'y')
                    {

                        Movie rem = Moviestock.Find(x => x.Movie_Name == movie.Movie_Name);
                        Moviestock.Remove(rem);
                        movielist.Add(rem);
                        Movie.Stock++;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Movie cancelled sucessfully");
                        foreach (Movie items in Moviestock)
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("The movies rented by you are:");
                            Console.Write(items.Movie_Name + " ");
                            Console.Write(items.Lang + " ");
                            Console.Write(items.Genre + " ");
                            Console.Write(items.runtime + " ");
                            Console.WriteLine();

                        }

                    }
                    else
                    {
                        Console.WriteLine("Movie will be delivered Soon");
                    }
                }

                else
                {  
                    Console.WriteLine("Movies are rented sucessfully");
                    foreach (Movie items in Moviestock)
                    {
                        items.Delivered_Time = DateTime.Now;
                        
                        Console.WriteLine("The movies you Rented are");
                        Console.Write(items.Movie_Name + " ");
                        Console.Write(items.Lang + " ");
                        Console.Write(items.Genre + " ");
                        Console.Write(items.runtime + " ");
                        Console.WriteLine(items.Delivered_Time + " ");
                        Console.WriteLine();
                        if (((DateTime.Now.Day + items.Days_Rented) - movie.runtime.Day) > 10)
                        {
                            Movie mov = new Movie();
                            OutstandingMovie.Add(movie);
                        }

                    }


                    DisplayOutMovies(OutstandingMovie);


                }
            }
        }



        public void DisplayOutMovies(List<Movie> m)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The following Movies have not been delivered for more than 10 days");
            foreach (Movie items in m)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("The movies you Rented are");
                Console.Write(items.Movie_Name + " ");
                Console.Write(items.Lang + " ");
                Console.Write(items.Genre + " ");
                Console.Write(items.runtime + " ");
                Console.WriteLine();

            }

        }



        public void AddUsers(List<Users> userlist)
        {
            Console.WriteLine("Do you want to add Users \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the number of Users to add");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Users user = new Users();
                    Console.WriteLine("Enter User_name");
                    user.User_name = Console.ReadLine();
                    Console.WriteLine("Enter Passwd");
                    user.Passwd = Console.ReadLine();
                    Console.WriteLine("Enter Phone Number");
                    user.Phone_num = Console.ReadLine();
                    Users check = userlist.Find(X => X.Phone_num == user.Phone_num);
                    if (check == null)
                    {
                        userlist.Add(user);

                    }
                    else
                    {
                        Console.WriteLine("User already Registered");
                    }


                }
                foreach (Users user in userlist)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(user.User_name);
                    Console.WriteLine(user.Passwd);
                    Console.WriteLine(user.Phone_num);
                    Console.WriteLine(user.Date_Added);
                    Console.WriteLine();
                }

            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }
        }

        public void UpdateUsers(List<Users> userlist)
        {
            Console.WriteLine("Do you want Update a User \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the Any one of the Users details to update");
                string search = Console.ReadLine();
                Users Name = userlist.Find(x => x.User_name == search || x.Passwd == search);
                Console.WriteLine("Enter the Updated UserName");
                Name.User_name = Console.ReadLine();
                Console.WriteLine("Enter the Updated Passwd");
                Name.Passwd = Console.ReadLine();
                Console.WriteLine("Enter the Updated Phone_num");
                Name.Phone_num = Console.ReadLine();
                foreach (Users user in userlist)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(user.User_name);
                    Console.WriteLine(user.Passwd);
                    Console.WriteLine(user.Phone_num);
                    Console.WriteLine(user.Date_Added);
                    Console.WriteLine();
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }
        }
        public void UpdateMovies(List<Movie> movielist)
        {
            Console.WriteLine("Do you want Update a Movie \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the Movie Name or Lang or genre to update");
                string search = Console.ReadLine();
                Movie Name = movielist.Find(x => x.Movie_Name == search || x.Lang == search || x.Genre == search);
                Console.WriteLine("Enter the Updated Movie Name");
                Name.Movie_Name = Console.ReadLine();
                Console.WriteLine("Enter the Updated Movie Lang");
                Name.Lang = Console.ReadLine();
                Console.WriteLine("Enter the Updated Movie Genre");
                Name.Genre = Console.ReadLine();
                Console.WriteLine("Enter the Updated Movie Movie_cost");
                Name.Movie_cost = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (Movie movie in movielist)
                {
                    Console.WriteLine(movie.Movie_Name);
                    Console.WriteLine(movie.Lang);
                    Console.WriteLine(movie.Genre);
                    Console.WriteLine(movie.Movie_cost);
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Thank you");
            }

        }

        public void AddMovies(List<Movie> movielist)
        {
            Console.WriteLine("Do you want add a Movie \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the number of movies to add");
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    Movie movie = new Movie();
                    Console.WriteLine("Enter Movie_Name");
                    movie.Movie_Name = Console.ReadLine();
                    Console.WriteLine("Enter Lang");
                    movie.Lang = Console.ReadLine();
                    Console.WriteLine("Enter Genre");
                    movie.Genre = Console.ReadLine();
                    Console.WriteLine("Enter Movie price");
                    movie.Movie_cost = int.Parse(Console.ReadLine());
                    movielist.Add(movie);
                    Console.ForegroundColor = ConsoleColor.Red;
                    foreach (Movie movies in movielist)
                    {
                        Console.WriteLine(movies.Movie_Name);
                        Console.WriteLine(movies.Lang);
                        Console.WriteLine(movies.Genre);
                        Console.WriteLine(movies.Movie_cost);
                    }
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }
        }

        public void DeleteMovies(List<Movie> movielist)
        {
            Console.WriteLine("Do you want Delete a Movie \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the Movie Name or Lang or genre to Delete");
                string search = Console.ReadLine();
                Movie Name = movielist.Find(x => x.Movie_Name == search || x.Lang == search || x.Genre == search);
                movielist.Remove(Name);
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (Movie movie in movielist)
                {
                    Console.WriteLine(movie.Movie_Name);
                    Console.WriteLine(movie.Lang);
                    Console.WriteLine(movie.Genre);
                    Console.WriteLine(movie.Movie_cost);
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }

        }
        public void DeleteUsers(List<Users> Userslist)
        {
            Console.WriteLine("Do you want Delete \n Yes or No");
            string opt = Console.ReadLine();
            if (opt == "Yes")
            {
                Console.WriteLine("Enter the Users details");
                string search = Console.ReadLine();

                Users Name = Userslist.Find(x => x.User_name == search || x.Passwd == search);
                Userslist.Remove(Name);
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (Users user in Userslist)
                {
                    Console.WriteLine(user.User_name);
                    Console.WriteLine(user.Passwd);
                    Console.WriteLine(user.Phone_num);
                    Console.WriteLine(user.Date_Added);
                    Console.WriteLine();
                }
            }
            else if (opt == "No")
            {
                Console.WriteLine("Ok! Thank you");
            }

        }
    }
}