/* 
 Create a array list of 5 elements and add, remove, count elements
*/
using System;
using System.Collections;

public class Prob4
{
    public static void Main()
    {
        var arr = new ArrayList();
        int k;
        Console.WriteLine("Enter 5 numbers");
        for (int i = 0; i < 5; i++)
        {
            k = Convert.ToInt32(Console.ReadLine());
            arr.Add(k); // add fun supported 
        }
        Console.WriteLine("Enter number to be removed");
        int j;
        j = Convert.ToInt32(Console.ReadLine());
        arr.Remove(j);
        Console.WriteLine("removed" + " " + j);
        Console.WriteLine("Array after removed");
        for (int i = 0; i < arr.Count; i++)
        {
            Console.WriteLine(arr[i]);
        }
        int p = arr.Count;
        Console.WriteLine("Number of elements in array");
        Console.WriteLine("Count" + " " + p);
        Console.ReadLine();
    }
}
