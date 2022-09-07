using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public abstract class Person
    {
        public abstract void work();

    }
    public class employees : Person
    {


        public override void work()
        {
            Console.WriteLine("calling emplpoyee");
        }
    }
    public class manager : Person
    {


        public override void work()
        {
            Console.WriteLine("calling manager");
        }
    }
    public class clerk : Person
    {


        public override void work()
        {
            Console.WriteLine("calling clerk");
        }
    }
}

