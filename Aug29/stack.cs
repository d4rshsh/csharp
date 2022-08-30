using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Userstack<string> u = new Userstack<string>();
            u.Push("BMW");
            u.Push("Mercedes Benz");
            u.Push("Aston Martin");
            Console.WriteLine("Popped element");
            u.Pop();
            Console.WriteLine("Elements at present");
            u.printData();
            Console.WriteLine("Top element at present");
            string k = u.Peek();
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
    class Userstack<T>
    {
        static int max = 1000;
        T[] stack = new T[max];
        int top = -1;
        public void Push(T str)
        {
            if (top >= 1000)
            {
                Console.WriteLine("can't push, limit reached");
            }
            else
            {
                stack[++top] = str; //prefix operator
            }
        }
        public void Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("No elements there to pop");
            }
            else
            {
                T value = stack[top--];
                Console.WriteLine(value);
            }
        }
        public T Peek()
        {
            if (top < 0)
            {
                return default(T);
            }
            else
            {
                T value = stack[top];
                return value;
            }
        }
        public void printData()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
