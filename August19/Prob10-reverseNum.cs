// Program to display the reverse of an entered number
internal class Program
{
    static void Main(string[] args)
    {
        int num;
        Console.WriteLine("Enter the number");
        num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The reverse order is");
        while (num > 0)
        {
            int i;
            i = num % 10;
            Console.Write(i);
            num = num / 10;
        }
        Console.ReadLine();
    }
}
