namespace aug17product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Problem 9 and 14 - temperature conversion");
            float celsius;
            Console.WriteLine("Enter celsium to convert K,F");
            celsius = Convert.ToInt32(Console.ReadLine());
            float kelvin = 273 + celsius;
            Console.WriteLine("Kelvin value is {0} degree K", kelvin);
            float fahren = ((celsius * 9) / 5) + 32;
            Console.WriteLine("Fahrenheit value is {0} degree F", fahren);
            Console.ReadLine();
        }
    }
}
