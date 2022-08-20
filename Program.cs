namespace swapnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            swap(a, b);
            Console.WriteLine("Actual numbers: {0} and {1}", a, b);
            gswap(ref a, ref b);
            Console.WriteLine("Actual numbers: {0} and {1}", a, b);
            Console.ReadLine();
        }
        static void swap(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Swapped numbers: {0} and {1}", a, b);
        }
        static void gswap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Swapped numbers: {0} and {1}", a, b);


        }
    }
}