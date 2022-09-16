using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;
using System.IO;
using AdminModule;
// using System.Web.Script.Serialization;
using System.Xml.Serialization;
using System.Runtime.CompilerServices;

namespace MovieApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Admin darsh = new Admin();
             File.Create("C:\\Users\\sures\\source\\repos\\User.txt");
            File.Create("C:\\Users\\sures\\source\\repos\\MoviesList.txt");
            Movie m1 = new Movie();
            m1.AddMovieDetails("SK", "Tamil", "Action", 50);
            Movie m2 = new Movie();
            m2.AddMovieDetails("KRK", "Tamil", "Romance", 60);
            Movie m3 = new Movie();
            m3.AddMovieDetails("DS", "English", "Mystery", 100);
            Movie m4 = new Movie();
            m4.AddMovieDetails("NEPV", "Tamil", "Romance", 60);
            Movie m5 = new Movie();
            m5.AddMovieDetails("SMS", "Tamil", "Comedy", 110);
            Movie m6 = new Movie();
            m6.AddMovieDetails("Don't Brethe", "English", "Thriller", 100);
            Movie m7 = new Movie();
            m7.AddMovieDetails("Deadpool", "English", "Action", 50);
            Movie m8 = new Movie();
            m8.AddMovieDetails("24", "Tamil", "Sci-fi", 120);
            Movie m9 = new Movie();
            m9.AddMovieDetails("MIB", "English", "Sci-fi", 120);
            Movie m10 = new Movie();
            m10.AddMovieDetails("West World", "English", "Sci-fi", 120);
            Movie m11 = new Movie("SMS", "Tamil", "Comedy", 110);
            Movie.Read();
            foreach (var item in Movie.MoviesList)
            {
                Console.WriteLine($"Movie Name : {item.Movie_Name}");
            }
            Console.WriteLine("Enter 1.User 2.Admin");
            int choice = Int32.Parse(Console.ReadLine());
            User u = new User();
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter Name : ");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enrter User Id : ");
                    long MobileNo = long.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Password : ");
                    string Password = Console.ReadLine();
                    Console.WriteLine("Enter UserLevel (Silver , Gold , Platinum) : ");
                    string level = Console.ReadLine();
                    u.AddUser(Name, MobileNo, Password, level);
                    bool condition;
                    do
                    {


                        Console.WriteLine("Enter 1.Borrow Movie 2.Return Movie 3.Show My List 4.Search Movie By Lang");
                        int ch = Int32.Parse(Console.ReadLine());
                        switch (ch)
                        {
                            case 1:
                                // Movie m = new Movie("ANAND","TAMIL" , "Action" ,20);
                                Console.WriteLine("Enter Movie Name : ");
                                string movieName = Console.ReadLine();
                                try
                                {
                                    //foreach (var item in Movie.MoviesList)
                                    //{
                                    //    if(item.Movie_Name == movieName)
                                    //    {
                                    //        u.BorrowMovie(item);
                                    //    }
                                    //}
                                    var found = Movie.MoviesList.Find((movie) => movie.Movie_Name == movieName);
                                    if (found != null)
                                    {
                                        u.BorrowMovie(found);
                                    }
                                    else
                                    {
                                        throw new Exception("Movie Not Found");
                                    }

                                    foreach (var item in u.BorrowedMovies)
                                    {
                                        Console.WriteLine($"Name : {item.Movie_Name}");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Error Message from borrowing" + ex.Message);

                                }
                                break;
                            case 2:
                                Console.WriteLine("Enter Movie Name You Want to return : ");
                                string Rmovie = Console.ReadLine();
                                Console.WriteLine("Enter Due days : ");
                                int days = Int32.Parse(Console.ReadLine());
                                try
                                {
                                    var found = Movie.MoviesList.Find((movie) => movie.Movie_Name == Rmovie);
                                    if (found != null)
                                    {
                                        u.ReturnMovie(found, days);
                                    }
                                    else
                                    {
                                        throw new Exception("Movie Not Found");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine(ex.Message);

                                }
                                break;
                            case 3:
                                u.ShowMyList();
                                break;
                            case 4:
                                Console.WriteLine("Enter Movie Lang");
                                string lang = Console.ReadLine();
                                u.SearchByLang(lang);
                                break;
                            default:
                                break;
                        }
                        Console.WriteLine("Do you want to Continue (yes/no) : ");
                        string ans = Console.ReadLine();
                        if (ans == "yes" || ans == "YES")
                        {
                            condition = true;
                        }
                        else
                        {
                            condition = false;
                        }
                    } while (condition);
                    break;
                case 2:
                    Console.WriteLine("Enter Password : ");
                    string s = Console.ReadLine();
                    if (s == "password")
                    {
                        Console.WriteLine("Enter 1.AddUser 2.Add Movies");
                        int ans = Int32.Parse(Console.ReadLine());
                        switch (ans)
                        {
                            case 1:
                                darsh.AddUserByAdmin();
                                break;
                            case 2:
                                darsh.WriteMovies();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password");
                    }
                    break;
                default:
                    break;
            }
            
            FileStream fs1 = new FileStream("SearchedMovies.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(User));

            xml.Serialize(fs1, u);
        
        }
    }
}