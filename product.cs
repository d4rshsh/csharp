namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
            Console.WriteLine("---Problem 2---");
            Console.WriteLine("Product of three numbers");
            Console.WriteLine("Enter number 1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 3");
            c = Convert.ToInt32(Console.ReadLine());
            double product;
            product = a * b * c;
            Console.WriteLine("Product is" + product);
            Console.ReadLine();
        }
    }
}
