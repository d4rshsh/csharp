using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;

namespace Sept13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovieConst m1 = new MovieConst();
            m1.AddMovieDetails("SK", "Tamil", "Action", 50);
            MovieConst m2 = new MovieConst();
            m2.AddMovieDetails("KRK", "Tamil", "Romance", 60);
            MovieConst m3 = new MovieConst();
            m3.AddMovieDetails("DS", "English", "Mystery", 100);
            MovieConst m4 = new MovieConst();
            m4.AddMovieDetails("NEPV", "Tamil", "Romance", 60);
            MovieConst m5 = new MovieConst();
            m5.AddMovieDetails("SMS", "Tamil", "Comedy", 110);
            MovieConst m6 = new MovieConst();
            m6.AddMovieDetails("Don't Brethe", "English", "Thriller", 100);
            MovieConst m7 = new MovieConst();
            m7.AddMovieDetails("Deadpool", "English", "Action", 50);
            MovieConst m8 = new MovieConst();
            m8.AddMovieDetails("24", "Tamil", "Sci-fi", 120);
            MovieConst m9 = new MovieConst();
            m9.AddMovieDetails("MIB", "English", "Sci-fi", 120);
            MovieConst m10 = new MovieConst();
            m10.AddMovieDetails("West World", "English", "Sci-fi", 120);
            MovieConst m11 = new MovieConst("SMS", "Tamil", "Comedy", 110);
            User u1 = new User();
            User u2 = new User();
            User u3 = new User();
            User u4 = new User();
            User u5 = new User();
            User u6 = new User();
            User u7 = new User();
            User u8 = new User();
            User u9 = new User();
            User u10 = new User();
            User u11 = new User();
            User u12 = new User();
            User u13 = new User();

            u2.AddUser("Darshan", "hello", "Silver");
            u3.AddUser("Darshan", "hello", "Silver");
            u4.AddUser("Darshan", "hello", "Silver");
            u5.AddUser("Darshan", "hello", "Silver");
            u6.AddUser("Darshan", "hello", "Silver");
            u7.AddUser("Darshan", "hello", "Silver");
            u8.AddUser("Darshan", "hello", "Silver");
            u9.AddUser("Darshan", "hello", "Silver");
            u10.AddUser("Darshan", "hello", "Silver");
            u12.AddUser("Darshan", "hello", "Silver");
            u13.AddUser("Darshan", "hello", "Silver");
            
            u1.BorrowMovie(m1);
            u2.BorrowMovie(m1);
            u4.BorrowMovie(m1);
            Console.WriteLine("MovieConst 1 Availability " + m1.Availability);
            u2.ReturnMovie(m1, 4);
            Console.WriteLine("MovieConst 1 Availability " + m1.Availability);
            u3.BorrowMovie(m1);
            u6.BorrowMovie(m1);
            u5.BorrowMovie(m1);
            u7.BorrowMovie(m1);
            u8.BorrowMovie(m1);
            u9.BorrowMovie(m1);
            u10.BorrowMovie(m1);
            u12.BorrowMovie(m1);
            u11.BorrowMovie(m1);
            u13.BorrowMovie(m1);
            u1.BorrowMovie(m2);
            u1.ReturnMovie(m2, 5);
            u1.BorrowMovie(m3);
            Console.WriteLine("=================================================");
            u1.ShowMyList();
            Console.WriteLine("==================================================");
            u1.SearchByLanguage("Tamil");
            Console.WriteLine("==================================================");
            u1.SearchByGenre("Romance");
            // m1.PrintAllMovies();

        }
    }
}