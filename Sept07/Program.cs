
using System;

namespace Sep07
{
    internal class Program
    {
        public delegate string stren5(string spo, string spo1);
        public delegate string stren6(string hon);
        static void Main(string[] args)
        {
            Console.WriteLine("PS 01");
            Console.WriteLine("Enter the string");
            string m = Console.ReadLine();
            strin s1 = new strin();
            stren s2 = new stren(s1.stringlen);
            s2(m);
            Console.WriteLine("==================");
            Console.WriteLine("PS 02");
            Console.WriteLine("Enter Username");
            string user = Console.ReadLine();
            stren s3 = new stren(s1.greet);
            s3(user);
            Console.WriteLine("==================");
            Console.WriteLine("PS 03");
            Console.WriteLine("Enter the two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            integer multicast = new integer();
            stren2[] d3 = new stren2[3] { multicast.Add, multicast.Sub, multicast.Multiply };
            stren2 d4 = (stren2)MulticastDelegate.Combine(d3);
            d4(a, b);
            Console.WriteLine("==================");
            Console.WriteLine("PS 04");
            Console.WriteLine("Enter Product ID and Product's name");
            Products prod = new Products();
            prod.PId = Convert.ToInt32(Console.ReadLine());
            prod.Name = Console.ReadLine();
            stren3 poi = new stren3(prod.Display);
            poi(prod);
            Console.WriteLine("==================");
            Console.WriteLine("PS 05");
            Console.WriteLine("Enter the Year,Month,Date in numeral format");
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int date = Convert.ToInt32(Console.ReadLine());
            Employee emp = new Employee();
            DateTime t = new DateTime(year, month, date);
            emp.Joining = t;
            stren4 se = new stren4(emp.Expyrs);
            int yexp = se(emp.Joining);
            Console.WriteLine($"Years of experience = {yexp}");
            Console.WriteLine("==================");
            Console.WriteLine("PS 06");
            Console.WriteLine("Enter strings to Concatenate");
            string text1 = Console.ReadLine();
            string text2 = Console.ReadLine();
            string str = text1+ text2;
            stren5 text = delegate (string so, string su)
            {
                string str1 = so + su;
                return str1;
            };
            string resultString = text(text1, text2);
            Console.WriteLine($"Concatenated string is {resultString}");
            Console.WriteLine("==================");
            Console.WriteLine("PS 07");
            // Console.WriteLine("Enter the string");
            // string kon = Console.ReadLine();
            stren6 df = delegate (string ki)
            {
                string p = " ";
                for (int i = 0; i < ki.Length; i++)
                {
                    if (i == 0)
                    {
                        p += char.ToUpper(ki[i]);
                    }
                    else
                    {
                        p += ki[i];
                    }
                }

                return p;
            };
            string pon = df(str);
            Console.WriteLine($"First Case upper => {pon}");
            Console.ReadLine();
        }
    }
}