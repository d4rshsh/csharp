/* 
You are making a game! The player tries to shoot an object and can hit or miss it.
The player starts with 100 points, with a hit adding 10 points to the player’s score, and a miss deducting 20 points.
Your program needs to take 4 action results as input ("hit" or "miss"), calculate and output the player’s remaining points
EXAMPLE INPUT:
HIT
MISS
HIT
HIT
EXAMPLE OUTPUT: 110 
*/

    internal class Program
{
    static void Main(string[] args)
    {
        int i;
        string str = " ";
        int sum = 100;
        for (i = 0; i < 4; i++)
        {
            str = Console.ReadLine();
            if (str.Equals("HIT"))
            {
                sum += 10;
            }
            else if (str.Equals("MISS"))
            {
                sum -= 20;
            }
        }
        Console.WriteLine(sum);
        Console.ReadLine();
    }
}
