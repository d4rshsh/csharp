int year;
Console.WriteLine("Enter the year");
year = Convert.ToInt32(Console.ReadLine());
if (year % 4 == 0)
{

    if (year % 100 == 0)
    {
        if (year % 400 == 0)
        {
            Console.WriteLine("{0} is a leap year",year);
        }
        else
            Console.WriteLine("{0} is not a leap year", year);

    }
    else
        Console.WriteLine("{0} is a leap year", year);

}
else
    Console.WriteLine("{0} is not a leap year", year);
Console.ReadLine();
