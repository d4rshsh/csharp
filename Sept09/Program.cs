using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Hands_on
{
    class Program
    {

        public static void m1()
        {
            Console.WriteLine("Function called using thread...");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} - {i}");
                Thread.Sleep(100);
            }
        }

        public static void m2(object data)
        {
            Console.WriteLine("Function called using ParameterizedthreadStart Delegate : " + data);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} - {i}");
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(m1);
            Thread t2 = new Thread(m2);

            t1.Name = "First_thread";
            t2.Name = "Second_thread";




            Console.WriteLine("----Before Start---- ");
            Console.WriteLine("Is {0} alive= {1}", t1.Name, t1.IsAlive);
            Console.WriteLine("Is {0} alive= {1}", t2.Name, t2.IsAlive);
            Console.WriteLine("Thread state of {0} = {1}", t1.Name, t1.ThreadState);
            Console.WriteLine("Thread state  of {0} = {1}", t2.Name, t2.ThreadState);


            // Priority with thread
            t2.Priority = ThreadPriority.Highest;
            t1.Priority = ThreadPriority.Lowest;



            t1.Start();
            t2.Start("Hello");

            Console.WriteLine("----After Start----");
            Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            Console.WriteLine("Thread state T1= " + t1.ThreadState);
            Console.WriteLine("Thread state T2= " + t2.ThreadState);

            //t1.Abort();
            //t2.Abort();
            //Console.WriteLine("----After Aborted----");
            //Console.WriteLine("Is T1 alive= " + t1.IsAlive);
            //Console.WriteLine("Is T2 alive= " + t2.IsAlive);
            //Console.WriteLine("Thread state T1= " + t1.ThreadState);
            //Console.WriteLine("Thread state T2= " + t2.ThreadState);


            Console.ReadLine();
        }
    }
}