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
            // LinkedList
            // string linked List
            
           /* GenericsLinkedList<string> stringLinkedList = new GenericsLinkedList<string>(); //object 1
            string s1 = "1. Lionel Messi";
            string s2 = "2. Pedri Gonzalez";
            string s3 = "3. Erling Braut Haaland";
            string s4 = "4. Kevin De Bruyne";
            stringLinkedList.AddHead(s1);
            stringLinkedList.AddHead(s2);
            stringLinkedList.AddHead(s3);
            stringLinkedList.AddHead(s4);
            //display List
            foreach (string str in stringLinkedList)
            {
                Console.WriteLine(str);
            }

            //Integer LinkedList
            GenericsLinkedList<int> integerList = new GenericsLinkedList<int>();
            int n1 = 1;
            int n2 = 2;
            int n3 = 3;

            integerList.AddHead(n1);
            integerList.AddHead(n2);
            integerList.AddHead(n3);

            foreach (int Intger in integerList)
            {
                Console.WriteLine(Intger);
            }


            Console.ReadKey(); */
            Console.ReadLine();
        }
    }
   
}
