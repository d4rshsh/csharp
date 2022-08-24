using ReusableCodeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass.PrintString();
          
            Console.WriteLine("Enter 1st text");
            string s1=Console.ReadLine();
            Console.WriteLine("Enter 2nd text");
            string s2 = Console.ReadLine();
            Prob1.CompareStr(s1,s2);


            Console.ReadLine();

        }
    }
}
