using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;


namespace Sept14
{
    internal class PS6
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


            FileStream fs = new FileStream(@"cost details.bin", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            movie9.Amount(movie2);
            bf.Serialize(fs, movie2);
            FileStream fs1 = new FileStream(@"Rent amount details1.xml", FileMode.Create, FileAccess.Write);
            movie1.Amount(movie10);
            XmlSerializer serial = new XmlSerializer(typeof(Movie));
            serial.Serialize(fs1, movie10);
            Console.WriteLine("File Added");
            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.ReadLine();


        }
    }
}