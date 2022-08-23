/*
Write a program to handle Divide By Zero exception and call the stack trace to get the line number
 */

namespace Aug23Exercises
{
    internal class Prob7
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter Numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            try
            {
                int div = a / b;
                Console.WriteLine(div);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.StackTrace);

            }
            Console.ReadLine();
        }
    }
}
