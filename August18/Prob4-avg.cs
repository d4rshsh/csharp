namespace aug18
{
    internal class Prob4
    {
        static void Main(string[] args)
        {
           //  Console.WriteLine("---Problem4---");
            int a,b,c,d;
            Console.WriteLine("Enter four numbers for average");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            int sum, avg;
            sum = a+b+c+d;
            avg = sum / 4;
            Console.WriteLine("{0}/4={1}", sum, avg);
            Console.ReadLine();
        }
    }
}
