/*
C# prg to create a list of float numbers and print it
 */


internal class Prob9
{
    static void Main(string[] args)
    {

        List<float> L = new List<float> { 0.045f, 0.67f, 7.3f }; // List<data-type> list_name = new List<data-type> {};
        float[] arr = new float[L.Count];
        for (int i = 0; i < L.Count; i++)
        {
            arr[i] = L[i];
        }
        Array.Sort(arr);
        Console.WriteLine("Ascending Order");
        foreach (float f in arr)
        {
            Console.WriteLine(f);
        }
        Array.Reverse(arr); // built in
        Console.WriteLine("Descending Order");
        foreach (float f in arr)
        {
            Console.WriteLine(f);
        }
        Console.ReadLine();
    }
}
