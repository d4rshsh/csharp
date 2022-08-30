using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // stack implementation
            /* Userstack<string> u = new Userstack<string>();
            u.Push("BMW");
            u.Push("Mercedes Benz");
            u.Push("Aston Martin");
            Console.WriteLine("Popped element");
            u.Pop();
            Console.WriteLine("Elements at present");
            u.printData();
            Console.WriteLine("Top element at present");
            string k = u.Peek();
            Console.WriteLine(k); */

            // Queue with array implementation
            /* LinearQueue Q = new LinearQueue(5);

            Q.insert(44);
            Q.insert(21);
            Q.insert(33);
            Q.insert(13);
            Q.insert(34);

            Console.WriteLine("Items are : ");
            Q.Queue();

            Q.delete();
            Q.delete();

            Console.WriteLine("Items are : ");
            Q.Queue(); */
            Console.ReadLine();
        }
    }
   
}
