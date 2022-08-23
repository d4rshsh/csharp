/*
Create a struct of employee with empno,ename,sal,deptno.
Create properties for the above 
 */
namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employees e1 = new employees();


            Console.WriteLine("Enter EmpNo");
            e1.empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Empname");
            e1.ename = Console.ReadLine();
            Console.WriteLine("Enter salary");
            e1.salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter DeptNo");
            e1.Dno = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Print the details");
            e1.display();

            Console.ReadLine();



        }
    }
    struct employees
    {
        public int EmpNo;
        public string Ename;
        public float Salary;
        public int deptno;
        public int empno
        {
            set
            {   EmpNo = value;  }
            get
            {   return EmpNo;   }
        }
        public string ename
        {
            set
            { Ename = value;  }
            get
            {  return Ename;  }
        }
        public float salary
        {
            set
            {    Salary = value;  }
            get
            {   return Salary;  }
        }
        public int Dno
        {
            set
            {    deptno = value;    }
            get
            {   return deptno;    }
        }
        public void display()
        {
            Console.WriteLine(" {0} \n {1} \n {2} \n {3}\n", EmpNo, Ename, Salary, deptno);
        }
    }
}
