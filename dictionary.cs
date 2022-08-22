/*
C# prg to create a Dictionary of int as key and name as string and display the dictionary.
 */


internal class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Lionel Messi");
        dict.Add(2, "Neymar");
        dict.Add(3, "Kylian Mbappe");

        foreach (KeyValuePair<int, string> item in dict)
        {
            Console.WriteLine(item.Key + " " + item.Value);

        }
        Console.ReadKey();

    }
}
