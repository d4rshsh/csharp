using ArrayObjLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug26
{
    public class Prob1

    {
        static void Main(string[] args)
        {
            Students[] s = new Students[2];



            for (int i = 0; i < student.Length; i++)
            {
                s[i] = new Students();
                Console.WriteLine("Enter Roll Number:");
                s[i].RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Student's name:");
                s[i].StudentName = Console.ReadLine();
                Console.WriteLine("Enter Grade");
                s[i].Grade = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("Student Details:");
            s[0].DisplayStudent();
            s[1].DisplayStudent();

            Console.ReadLine();
        }
    }
    struct Students
    {
        public char Grade;

        public void AcceptDataStudent(int rollno, string sname, char grade)
        {
            RollNo = rollno;
            StudentName = sname;
            Grade = grade;
        }
        public void DisplayStudent()
        {

            Console.WriteLine("RollNo : " + RollNo);
            Console.WriteLine("StudentName : " + StudentName);
            Console.WriteLine("Grade : " + Grade);
            Console.WriteLine();
        }
        int rollno;
        public int RollNo
        {
            get { return rollno; }
            set
            { if (value != 0)
                {
                    rollno = value;
                }
                else
                {
                    Console.WriteLine("Roll Number cannot be zero or null");
                }
            }
        }
        string sname;

        public string StudentName
        {
            get { return sname; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Student Name cannot be null");
                }
                else
                {
                    sname = value;
                }

            }
        }
    }

}
