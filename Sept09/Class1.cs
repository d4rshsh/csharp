using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_Hands_on
{
    internal class MutexThread
    {
        static void Main(string[] args)
        {
            //imterprocess
            using (Mutex mutex = new Mutex(false, "ThreadingDemo"))
            {

                if (!mutex.WaitOne(5000, false))
                {
                    Console.WriteLine("already running....");
                    Console.ReadLine();
                    return;

                }
                else
                {
                    Console.WriteLine("app is running");
                    Console.ReadLine();
                }

            }

        }
    }
}