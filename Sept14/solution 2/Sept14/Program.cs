using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ClassLibrary1;

namespace Sept14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream(@"C:\Users\sures\source\repos\Sept14\user.bin", FileMode.Open, FileAccess.Read);
            BinaryFormatter formatter = new BinaryFormatter();
            CustomerUser user = (CustomerUser)formatter.Deserialize(fs);
            Console.WriteLine(user.LoginDetails);
            Console.WriteLine(user.date);

            fs.Flush();
            fs.Close();
            fs.Dispose();
            Console.ReadLine();

        }
    }
}