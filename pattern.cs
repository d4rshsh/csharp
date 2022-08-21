namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 7 -- Pattern");
            int n;
            Console.WriteLine("Enter digit for pattern");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("{0} {0} {0} {0}", n);
                else
                    Console.WriteLine("{0}{0}{0}{0}", n);

            }
            Console.ReadLine();
        }
    }
}
