namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Problem8 - pattern rectangle");
            int rect;
            Console.WriteLine("Enter digit for rectangle pattern");
            rect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", rect);
            int re = 0;
            while (re < 3)
            {
                Console.WriteLine("{0} {0}", rect);
                re++;
            }
            Console.WriteLine("{0}{0}{0}", rect);
            Console.ReadLine();
        }
    }
}
