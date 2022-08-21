namespace aug18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Problem 13 - metre to kilometre conversion");
            int m;
            Console.WriteLine("Enter metres");
            m = Convert.ToInt32(Console.ReadLine());
            float km = m / 1000;
            Console.WriteLine("meter to km is {0}", km);
            int kilo;
            Console.WriteLine("Enter kilometer");
            kilo = Convert.ToInt32(Console.ReadLine());
            int metre;
            metre = 1000 * kilo;
            Console.WriteLine("km to meter is {0}", metre);
            Console.ReadLine();
        }
    }
}
