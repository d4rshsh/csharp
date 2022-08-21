int a, b;
Console.WriteLine("Enter the numbers");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
// c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("{0} is largest", a);
}
else if (b > a)
{
    Console.WriteLine("{0} is largest", b);

}
else
    Console.WriteLine("Numbers are equal or invalid input");
Console.ReadLine();
