/*
C# prg to create a Dictionary of int as key and name as string and display the dictionary.
 */
using System.Collections;

    internal class Prob11
    {
        static void Main(string[] args)
        {



            SortedList<int, string> dict = new SortedList<int, string>();
            dict.Add(2, "Erling Brait Haaland");
            dict.Add(1, "Philip Walter Foden");
            dict.Add(3, "Kevin de Bruyne");

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " " + item.Value);

            }
            Console.ReadKey();


            Console.ReadLine();
        }
    }

