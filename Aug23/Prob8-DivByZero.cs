/*
Write a method to handle Divide By Zero exception and call the stack trace to get the line number by calling method in the main
 */

namespace Aug23Exercises
{
    internal class Prob8
    {
        static void Main(string[] args)
        {
            int a, b;
            int div;
            Console.WriteLine("Enter Numbers ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Divide(a, b);

            Console.ReadLine();
        }
        static void Divide(int x, int y)
        {
            try
            {
                int div;
                div = x / y;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.StackTrace);

            }

        }
    }
}
