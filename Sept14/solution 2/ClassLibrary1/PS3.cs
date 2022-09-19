using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary1;
// using System.Web.Script.Serialization;
// using Newtonsoft.Json;
using Nancy.Json;

namespace Sept14
{
    public class PS3
    {
        static void Main(string[] args)
        {
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
            
            List<Movie> MoviesAlreadyWatched = new List<Movie>();
            foreach (Movie movie in movielist)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(movie.Movie_Name);
                Console.WriteLine(movie.Genre);
                Console.WriteLine(movie.Lang);

                Console.WriteLine("Have you seen this movie \n Yes or No");
                string choice = (Console.ReadLine());

                if (choice == "Yes" || choice == "yes")
                {
                    MoviesAlreadyWatched.Add(movie);

                }

            }
            Movie[] seen = MoviesAlreadyWatched.ToArray();
            FileStream fs = new FileStream(@"MoviesAlreadyWatched.json", FileMode.Create, FileAccess.Write);
            JavaScriptSerializer serial = new JavaScriptSerializer();
            StreamWriter sw = new StreamWriter(fs); StringBuilder sb = new StringBuilder();
            Console.WriteLine(sb);
           // serial.Serialize(seen, sb);
            sw.Write(sb + "\n");



            sw.Flush();
            fs.Flush();
            sw.Close();
            fs.Close();
            sw.Dispose();
            fs.Dispose();
            Console.WriteLine("File Added");
            Console.ReadLine();


        }

    }
}