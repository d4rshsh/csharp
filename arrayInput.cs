/* 
Write a program in C# Sharp to store elements in an array and print it.  
*/
using System;
    
        int[] array = new int[10];
        int i;
        Console.Write(" Enter 10 elements for an array \n");
        for (i = 0; i < 10; i++) // take input from the user one by one
        {
            Console.Write("Entry number {0} : ", i + 1);
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("\n Elements in the array are: ");
        for (i = 0; i < 10; i++) // display elements of the array
        {
            Console.WriteLine("{0} ", array[i]);
        }
    
