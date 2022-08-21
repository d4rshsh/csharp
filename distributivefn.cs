namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 5 ");
            int a, b, c;
            Console.WriteLine("Enter three numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int op1 = (a + b) * c;
            int op2 = (a * b) + (b * c);
            Console.WriteLine("(x+y).z={0}", op1);
            Console.WriteLine("(x.y)+(y.z)={0}", op2);
            Console.ReadLine();
        }
    }
}
