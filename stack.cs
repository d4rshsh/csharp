/*
Create a stack of numbers, push, pop,peek,count, print before pop and after pop.
Find the topmost element on the stack.
*/
using System.Collections;

    internal class Prob6
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            Console.WriteLine("Pushing into stack");
            for (int i = 0; i < 4; i++)
            {
                s.Push(i); // push inbuilt
            }
            object a = s.Pop(); // pop from stack
            Console.WriteLine("Popped Element {0} ", a);
            int count = s.Count;
            Console.WriteLine("Count {0} ", count);
            Console.WriteLine("Top element {0}", s.Peek()); // top element of stack



            Console.ReadLine();

        }
    }
