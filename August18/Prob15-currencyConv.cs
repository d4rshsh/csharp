namespace aug18(15)
{
    internal class Prob15
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 15 - USD to INR conversion");
            Console.WriteLine("Enter amount of USD");
            int usd;
            usd = Convert.ToInt32(Console.ReadLine());
            double rupee = 79.62 * usd;
            Console.WriteLine("${0}  is {1} INR",usd, rupee);
            Console.ReadLine();
        }
    }
}
