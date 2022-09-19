using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.IO;
using System.Xml.Serialization;

namespace Sept14
{
    public class Ex2
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



            Console.WriteLine("Genre :- \n 1. Romance \n 2.Action \n 3.Documentary \n 4.Sci-fi \n 5.Drama \n 6.Thriller \n 7.Fantasy" );
            Console.WriteLine("Languages :- \n 1.Tamil \n 2.English \n 3.Hindi \n 4.Telugu");
            Console.WriteLine("Enter the language or genre to search the movies");
            string search = Console.ReadLine();
            List<Movie> Searchedmovies = movielist.FindAll(x => x.Genre == search || x.Lang == search);
            FileStream fs = new FileStream(@"MoviesList.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer serialized_doc = new XmlSerializer(typeof(List<Movie>));
            serialized_doc.Serialize(fs, Searchedmovies);
            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.WriteLine("File added");
            Console.ReadLine();

        }
    }
}
// here we insert the movies and use serialization and file handling techniques
