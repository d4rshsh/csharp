using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.IO;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Runtime.Serialization.Formatters.Binary;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Sept14
{
    public class PS5
    {
        static void Main(string[] args)
        {
            List<Users> userslist = new List<Users>();
            Users user1 = new Users() { User_name = "darsh", Passwd = "10142000", Phone_num = "7358952929", Date_Added = new DateTime(2022, 04, 10) };
            Users user2 = new Users() { User_name = "sesh", Passwd = "03062002", Phone_num = "9626877510", Date_Added = new DateTime(2022, 04, 17) };
            Users user3 = new Users() { User_name = "Ashwin", Passwd = "100198", Phone_num = "7010396490", Date_Added = new DateTime(2022, 06, 13) };
            Users user4 = new Users() { User_name = "Ashmi", Passwd = "230520", Phone_num = "8344425080", Date_Added = new DateTime(2022, 02, 10) };

            userslist.Add(user1);
            userslist.Add(user2);
            userslist.Add(user3);
            userslist.Add(user4);
            char ch = 'Y';
            while (ch == 'Y')
            {
                Console.WriteLine("1 for Register\n 2 for Edit Details");
                int op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Users newuser = new Users();
                            newuser.RegisterUser(newuser, userslist);
                            FileStream fs = new FileStream(@"user details.xml", FileMode.Create, FileAccess.Write);
                            XmlSerializer serial = new XmlSerializer(typeof(List<Users>));
                            serial.Serialize(fs, userslist);
                            fs.Flush();
                            fs.Close();
                            fs.Dispose();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("file added");

                            break;
                        }
                    case 2:
                        {
                            Users newuser = new Users();
                            newuser.EditUserData(newuser, userslist);
                            FileStream fs = new FileStream(@"user details.xml", FileMode.Create, FileAccess.Write);
                            XmlSerializer serial = new XmlSerializer(typeof(List<Users>));
                            serial.Serialize(fs, userslist);
                            fs.Flush();
                            fs.Close();
                            fs.Dispose();
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("file added");

                            break;
                        }
                }
                Console.WriteLine("Do you want to continue ? (y/n)");
                char an = Convert.ToChar(Console.ReadLine());
                if (an == 'Y' || an == 'y')
                {
                    ch = 'Y';
                }
                else
                {
                    break;
                }

            }

            Console.ReadLine();
        }
    }
}