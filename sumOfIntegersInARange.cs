// Program to display the sum of integers between 100 and 200
internal class Program
{
    static void Main(string[] args)
    {
        int sum=101;
        int i = 101;
        while ((i > 100) && (i< 200))
        {
            sum += i;
            i++;
        }
        Console.WriteLine("The sum of all integers between 100 and 200  is {0}",sum);
        Console.ReadLine();
    }
}
