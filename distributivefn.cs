namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem6 - Input Age");
            int age;
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You look older than {0}", age);
            Console.ReadLine();
        }
    }
}
