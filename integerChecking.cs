namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Problem 10 - integer checking");
            int a, b;
            Console.WriteLine("Enter two integers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if ((a < 0 && b> 0) || (a > 0 && b < 0))
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}
