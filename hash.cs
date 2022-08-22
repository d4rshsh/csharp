/*
Hash table
 */
using System.Collections;

    internal class Prob8
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable(); // obj
            h.Add(1, "Laptop");
            h.Add(2, "TV");
            h.Add(3, "Washing machine");
            h.Add(4, "Refrigerator");
            IDictionaryEnumerator he = h.GetEnumerator();
            Console.WriteLine("Using While loop");
            while (he.MoveNext())
            {
                Console.Write("{0}\t", he.Key); // Key-Value pair
                Console.Write("{0}\n", he.Value);
            }
            Console.WriteLine("Using for each loop");
            foreach (DictionaryEntry values in h) //defines a dictionary kv pair that can be retrieved
            {
                Console.Write("{0}\t", values.Key);
                Console.Write("{0}\n", values.Value);
            }
            Console.ReadLine();

        }
    }
