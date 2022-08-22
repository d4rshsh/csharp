namespace Aug22Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {

          
            int[][] classroom = new int[4][];
            classroom[0] = new int[] { 1, 25 };
            classroom[1] = new int[] { 2, 26 };
            classroom[2] = new int[] { 3, 28 };
            classroom[3] = new int[] { 4, 29 };
            foreach (int[] array in classroom)
            {
                foreach(int i in array)
                {
                    Console.Write("{0}\t",i);
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();


        }
    }
}
