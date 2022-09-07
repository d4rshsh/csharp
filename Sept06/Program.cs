using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

 

namespace sept6_hands_on
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p;
            p = new employees();
            p.work();
            p = new manager();
            p.work();
            p = new clerk();
            p.work();    //1
            Console.WriteLine("-----------------------------------------");
            bank b1 = new bank();
            b1.print_balance();
            b1.calc_interest();     //2
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("savings account");
            banks b = new savi();
            b.print_balance();
            b.calc_interest();
            Console.WriteLine("current aacount");
            banks b2 = new current();
            b2.print_balance();
            b2.calc_interest();   //3   //4    
            Console.WriteLine("-----------------------------------------");
            bankss g = new bankss();



            g.current();
            g.savings();
            g.deposits();
            g.withdraw();
            g.total_balc();
            g.deposits1();
            g.withdraw1();
            g.total_balc1();            //5  //6   


            Console.WriteLine("-----------------------------------------");

            Console.ReadLine();


        }
    }
}
