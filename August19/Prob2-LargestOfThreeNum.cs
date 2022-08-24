int a, b, c;
Console.WriteLine("Enter the numbers");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if (a >= b && a >= c)
{
    Console.WriteLine("{0} is largest", a);
}
else if (b > a && b > c)
{
    Console.WriteLine("{0} is largest", b);

}
else
{
    Console.WriteLine("{0} is largest", c);

}
Console.ReadLine();
