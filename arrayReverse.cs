/* 
Write a program in C# Sharp to read n number of values in an array and display it in reverse order.   
*/
using System;
public class Exercise2
{
    public static void Main()
    {
        int i, n;
        int[] arr = new int[100];


        Console.WriteLine("Enter size of array :");
        n = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Input {0} number of elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i+1);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nThe values in the array are : \n");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("{0}  ", arr[i]);
        }

        Console.Write("\n\nThe values in array in reverse are :\n");
        for (i = n - 1; i >= 0; i--) // reverse loop
        {
            Console.WriteLine("{0} ", arr[i]);
        }
}
