using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sep07
{
    public delegate void stren(string s);
    public delegate void stren2(int i, int j);
    public delegate void stren3(Products p);
    public delegate int stren4(DateTime t);
    public class strin
    {
        //  PS 1
        public void stringlen(string s)
        {
            Console.WriteLine("Length of string entered is {0} ",s.Length);

        }
        // PS 2
        public void greet(string s)
        {
            Console.WriteLine($"Hello {s}, how are you doing today?");
        }
    }

        // PS 3
    public class integer
    {
        public void Add(int i, int j)
        {
            Console.WriteLine($"Addition = {i + j}");
        }
        public void Sub(int i, int j)
        {
            if (i > j)
            {
                Console.WriteLine($"Subtraction = {i - j}");
            }
            else
            {
                Console.WriteLine($"Subtraction = {j - i}");
            }
        }
        public void Multiply(int i, int j)
        {
            Console.WriteLine($"Multiplication = {j * i}");
        }

    }

        // PS 4
    public class Products
    {
        public int PId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public void Display(Products p)
        {
            Console.WriteLine($"Product ID = {p.PId} and Product name is {p.Name}");
        }
    }
        // PS 5
    public class Employee
    {
        private DateTime joiningYear;
        public DateTime Joining
        {
            get { return joiningYear; }
            set { joiningYear = value; }
        }
        public int Expyrs(DateTime date)
        {
            int YearsOfService = DateTime.Now.Year - date.Year;
            return YearsOfService;
        }
    }
}