using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayObjLibrary;

namespace Aug26
{
    public class Prob2
    {
        static void Main(string[] args)
        {
            Students[] s = new Students[2];
            for (int i = 0; i < student.Length; i++)
            {
                s[i] = new Students();
                Console.WriteLine("Enter Roll Number");
                s[i].RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student's name");
                s[i].StudentName = Console.ReadLine();
                Console.WriteLine("Enter Grade");
                s[i].Grade = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("Student Details:");
            s[0].DisplayStudent();
            s[1].DisplayStudent();

            Console.ReadLine();
        } 

    }
}
