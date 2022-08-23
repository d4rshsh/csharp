namespace aug18
{
    internal class Prob3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Problem--3");
            Console.WriteLine("Arithmetic Operations - Add,Sub,Div,Mul,Rem");
            int a, b;
            Console.WriteLine("Enter the first number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition");
            int add = a + b;
            Console.WriteLine("{0} + {1}={2}", a, b, add);
            Console.WriteLine("Subtraction");
            int sub = a - b;
            Console.WriteLine("{0}-{1}={2}", a, b, sub);
            Console.WriteLine("Multiplication");
            int prod = a * b;
            Console.WriteLine("{0}*{1}={2}", a, b, prod);
            Console.WriteLine("division");
            float div = a / b;
            Console.WriteLine("{0}/{1}={2}", a, b, div);
            Console.WriteLine("Remainder");
            int rem = a % b;
            Console.WriteLine("{0} mod {1}={2}", a, b, rem);
            Console.ReadLine();
        }
    }
}
