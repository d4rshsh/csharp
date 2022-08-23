/*
Create a struct of employee with empno,ename,sal,deptno as fields
and write methods to Accept and Display Data
 */
namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employees b1 = new employees();

            int EmpNo;
            string Ename;
            float Salary;
            int Dno;
            Console.WriteLine("Enter Employee Number");
            EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Employee's name");
            Ename = Console.ReadLine();
            Console.WriteLine("Enter salary of employee");
            Salary = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Departtment Number");
            Dno = Convert.ToInt32(Console.ReadLine());
            b1.AcceptData(EmpNo, Ename, Salary, Dno);

            Console.WriteLine("Print the details");
            b1.display();

            Console.ReadLine();



        }
    }
    struct employees
    {
        public int EmpNo;
        public string Ename;
        public float Salary;
        public int deptno;
        public void AcceptData(int employee_no, string emp_name, float sal, int dept_no)
        {
            EmpNo = employee_no;
            Ename = emp_name;
            Salary = sal;
            deptno = dept_no;
        }



        public void display()
        {
            Console.WriteLine(" {0}\n {1}\n {2}\n {3}\n", EmpNo, Ename, Salary, deptno);
        }
    }
}
