// Program to calculate percentage of three marks and categorise them as Fail/First/Second/Third
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            int sum;
            float avg;
            sum = a + b + c;
            avg = sum / 3;
            if (avg < 35)
            {
                Console.WriteLine("Fail");
            }
            else if (avg > 35 && avg < 45)
                Console.WriteLine("third");
            else if (avg > 45 && avg < 60)
                Console.WriteLine("second");
            else
            {
                Console.WriteLine("first");
            }
            Console.ReadLine();
        }
    }
