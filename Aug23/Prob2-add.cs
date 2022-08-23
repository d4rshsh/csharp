/*
 Method to add 2 nos which have return type as int and call it in Program
 */
namespace Aug23Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Enter Numbers");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = addition(n1, n2);
            Console.WriteLine("Sum={0}", sum);
            Console.ReadLine();
        }
        static int addition(int sum, int k)
        {
            return (sum + k);

        }
    }
}
