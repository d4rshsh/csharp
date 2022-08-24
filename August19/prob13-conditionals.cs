/* program that prompts a user for input, accepts an integer,
 then evaluates whether that input is zero, odd or even, a multiple of 10, or too large
 (more than 100) by using multiple levels of if statements. */

    internal class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter the number");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 0)
            Console.WriteLine("number is zero");
        else if (num % 2 == 0)
        {
            Console.WriteLine("even");
            if (num % 10 == 0)
            {
                Console.WriteLine("{0} is a multiple of 10", num);
            }
            else
            {
                Console.WriteLine("{0 is }not a multiple of 10",num);
            }
            if (num > 100)
                Console.WriteLine("too large");
        }
        else
        {
            Console.WriteLine("odd");
            Console.WriteLine("{0} is not a multiple of 10",num);
            if (num > 100)
                Console.WriteLine("out of bounds");

        }
        Console.ReadLine();
    }
}
