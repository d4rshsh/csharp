/*
 Queue of int numbers, enqueue, dequeue and peek elements.
 */
using System.Collections;

    internal class Prob7
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(10, 2);//FIFO principle --First in first out
            q.Enqueue(67);
            q.Enqueue(5352.55f);
            q.Enqueue(26);

            q.Peek();
            Console.WriteLine("Before trimming=" + q.Count);
            q.TrimToSize(); // inbuilt function
            Console.WriteLine("After trimming");
            Console.WriteLine(q.Count);
            Console.WriteLine("Q elements are ");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();

        }
    }
