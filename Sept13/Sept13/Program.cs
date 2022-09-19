using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserModule;

namespace Sept13
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<Users> userslist = new List<Users>();
            Users user1 = new Users() { User_name = "darsh", Passwd = "10142000", Phone_num = "7358952929", Date_Added = new DateTime(2022, 04, 10) };
            Users user2 = new Users() { User_name = "sesh", Passwd = "03062002", Phone_num = "9626877510", Date_Added = new DateTime(2022, 04, 17) };
            Users user3 = new Users() { User_name = "", Passwd = "23345", Phone_num = "1234567878", Date_Added = new DateTime(2022, 06, 13) };
            Users user4 = new Users() { User_name = "Ashmi", Passwd = "230520", Phone_num = "8344425080", Date_Added = new DateTime(2022, 02, 10) };
            
            userslist.Add(user1);
            userslist.Add(user2);
            userslist.Add(user3);
            userslist.Add(user4);

            List<Movie> movielist = new List<Movie>();
            Movie movie1 = new Movie() { Movie_Name = "Vikram", Lang = "Tamil", Genre = "Thriller", Movie_cost = 80 };
            Movie movie2 = new Movie() { Movie_Name = "Sita Ramam", Lang = "Tamil", Genre = "Romance", Movie_cost = 60 };
            Movie movie3 = new Movie() { Movie_Name = "KGF2", Lang = "Telugu", Genre = "Action", Movie_cost = 60 };
            Movie movie4 = new Movie() { Movie_Name = "Asuran", Lang = "Tamil", Genre = "Drama", Movie_cost = 70 };
            Movie movie5 = new Movie() { Movie_Name = "Cobra", Lang = "Tamil", Genre = "Sci-fi", Movie_cost = 50 };
            Movie movie6 = new Movie() { Movie_Name = "Ae Dil Hai Mushkil", Lang = "Hindi", Genre = "Romance", Movie_cost = 100 };
            Movie movie7 = new Movie() { Movie_Name = "Maara", Lang = "Tamil", Genre = "Documentary", Movie_cost = 160 };
            Movie movie8 = new Movie() { Movie_Name = "Jai Bhim", Lang = "Tamil", Genre = "Drama", Movie_cost = 30 };
            Movie movie9 = new Movie() { Movie_Name = "Psycho", Lang = "Tamil", Genre = "Thriller", Movie_cost = 40 };
            Movie movie10 = new Movie() { Movie_Name = "Pride and Prejudice", Lang = "English", Genre = "Fantasy", Movie_cost = 80 };
            Movie movie11 = new Movie() { Movie_Name = "Kathuvaakula Rendu Kaadhal", Lang = "Tamil", Genre = "Romance", Movie_cost = 65 };

            movielist.Add(movie1);
            movielist.Add(movie2);
            movielist.Add(movie3);
            movielist.Add(movie4);
            movielist.Add(movie5);
            movielist.Add(movie6);
            movielist.Add(movie7);
            movielist.Add(movie8);
            movielist.Add(movie9);
            movielist.Add(movie10);
            movielist.Add(movie11);
          
            Movie.Stock = movielist.Count();
            Console.WriteLine("1.User Module 2.Admin Module 3.Common Options");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter User_name and Passwd");
                        Action<string, string> Login = (string username, string password) =>
                        {
                            Users Name = userslist.Find(x => x.User_name == username);
                            Users Pass = userslist.Find(x => Name.Passwd == password);
                            if (Name != null)
                            {
                                if (Pass != null)
                                {
                                    Console.WriteLine("Logged In " + Name.User_name + "!!");
                                    Console.WriteLine("The Top Rated Movies Rented By others are :");
                                    foreach (Movie Movies in movielist)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Magenta;
                                        Console.WriteLine(Movies.Movie_Name);
                                        Console.WriteLine(Movies.Lang);
                                        Console.WriteLine(Movies.Genre);
                                        Console.WriteLine("______________________");
                                    }
                                    char c = 'Y';
                                    while (c == 'Y')
                                    {
                                        Console.WriteLine("Select 1 to search Movies \n select 2 to rent movies");
                                        int sel = int.Parse(Console.ReadLine());
                                        switch (sel)
                                        {
                                            case 1:
                                                user1.SearchByLangOrGenre(movielist);
                                                break;
                                            case 2:
                                                user2.Renting(movielist, Pass);
                                                break;
                                            default:
                                                Environment.Exit(1);
                                                break;
                                        }
                                        Console.WriteLine("Do you want to continue (Y/N)");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        if (ch == 'Y' || ch == 'y')
                                        {
                                            c = 'Y';
                                        }
                                        else
                                        {
                                            break;
                                        }
                                    }


                                }
                                else
                                {
                                    Console.WriteLine("Passwd is incorrect");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No user found");
                            }

                        };
                        Login(Console.ReadLine(), Console.ReadLine()); ;
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Admin Operation to perform");
                        Console.WriteLine("1.Users Modification 2.Movie Modifications");
                        int Opt = int.Parse(Console.ReadLine());
                        Admin admin = new Admin();
                        switch (Opt)
                        {
                            case 1:
                                {
                                    Console.WriteLine("Enter 1 for Add User \n 2 for Update User \n 3 for delete User");
                                    int n = int.Parse(Console.ReadLine());
                                    if (n == 1)
                                    {
                                        admin.AddUsers(userslist);
                                    }
                                    else if (n == 2)
                                    {
                                        admin.UpdateUsers(userslist);
                                    }
                                    else if (n == 3)
                                    {
                                        admin.DeleteUsers(userslist);
                                    }
                                    break;
                                }
                            case 2:
                                {
                                    Console.WriteLine("Enter 1 for Add Movie \n 2 for Update Movie \n 3 for delete Movie");
                                    int n = int.Parse(Console.ReadLine());
                                    if (n == 1)
                                    {
                                        admin.AddMovies(movielist);
                                    }
                                    else if (n == 2)
                                    {
                                        admin.UpdateMovies(movielist);
                                    }
                                    else if (n == 3)
                                    {
                                        admin.DeleteMovies(movielist);
                                    }
                                    break;
                                }

                        }
                        break;

                    }
                case 3:
                    {
                        Console.WriteLine("Enter the action to perform");
                        Console.WriteLine("Enter\n 1 for Change Passwd \n 2 User option to change and view profile");
                        Option commonopt = new Option();
                        int n = int.Parse(Console.ReadLine());
                        if (n == 1)
                        {
                            Console.WriteLine("Enter User_name");
                            string name = Console.ReadLine();
                            Users sel1 = userslist.Find(x => x.User_name == name);

                            if (sel1 != null)
                            {

                                commonopt.changePassword(userslist, sel1);

                            }




                        }
                        else if (n == 2)
                        {
                            commonopt.userpro(userslist);


                        }
                        break;
                    }

            }








            Console.ReadLine();
        }
    }


}