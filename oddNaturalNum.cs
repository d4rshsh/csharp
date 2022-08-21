// Program to display the n terms of odd natural numbers and their sum
internal class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("Enter the numbers");
        n = Convert.ToInt32(Console.ReadLine());
        int i, j = 1, sum = 0;
        for (i = 1; i <= n; i++) // natural num loop from 1
        {
            Console.WriteLine(j);
            sum += j;
            j += 2;

        }
        Console.WriteLine("Sum is {0}",sum);
        Console.ReadLine();
    }
}
