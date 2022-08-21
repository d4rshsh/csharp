namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Problem 11 - Integer Checking 2");
            int a,b;
            Console.WriteLine("Two numbers  // only if Both pos returns true");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            Console.ReadLine();
        }
    }
}
