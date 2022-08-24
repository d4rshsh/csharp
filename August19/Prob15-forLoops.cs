/* 
 Create a program that initializes a variable i at 0 and counts up,
and initializes a second variable j at 25 and counts down. 
Use a single for loop to increment i and decrement j simultaneously,
and output the values of i and j at each iteration of the loop. When i is greater than j,
end the loop and print out the message “Crossed over!”
 */
internal class Program
{
    static void Main(string[] args)
    {
        int i=0, j=25;

        for (i = 0, j = 25; i < 25 && j >= 0; i++, j--)
        {
            if (i > j)
            {
                Console.WriteLine("Crossed Over");
                break;
            }
            Console.WriteLine("{0} {1}", i, j);

        }
        Console.ReadLine();
    }
}
