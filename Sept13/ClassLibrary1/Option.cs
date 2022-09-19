using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModule
{
    public class Option
    {
        public void changePassword(List<Users> userlist, Users usere)
        {

            Console.WriteLine("Enter Passwd");
            string pass = Console.ReadLine();
            Users user = userlist.Find(x => usere.Passwd == pass);
            if (user != null)
            {
                DateTime AddedDate = usere.Date_Added;
                DateTime now = DateTime.Now;
                if ((now.Month - AddedDate.Month) >= 1)
                {
                    Console.WriteLine("Change your Passwd");
                    Console.WriteLine("Enter New Passwd");
                    usere.Passwd = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("After changing Passwd");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(usere.User_name);
                    Console.WriteLine(usere.Passwd);
                    Console.WriteLine(usere.Phone_num);
                }
                else
                {
                    Console.WriteLine("Thank you!!!");

                }


            }
            else
            {
                Console.WriteLine("Incorrect Password, Try Again");
            }



        }
        public void userpro(List<Users> userslist)
        {
            Console.WriteLine("Enter User name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string pass = Console.ReadLine();
            Users u1 = userslist.Find(x => x.User_name == name);

            if (u1 != null)
            {
                Users sel2 = userslist.Find(x => u1.Passwd == pass);
                if (sel2 != null)
                {
                    Console.WriteLine("User Name : " + u1.User_name);
                    Console.WriteLine("Password: " + u1.Passwd);
                    Console.WriteLine("Phone number: " + u1.Phone_num);
                    Console.WriteLine("Added date : " + u1.Date_Added);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to Update Details\n Yes or No");
                    string op = Console.ReadLine();
                    if (op == "Yes" || op == "yes")
                    {
                        Console.WriteLine("Enter the Updated UserName");
                        u1.User_name = Console.ReadLine();
                        Console.WriteLine("Enter the Updated Passwd");
                        u1.Passwd = Console.ReadLine();
                        Console.WriteLine("Enter the Updated Phone_num");
                        u1.Phone_num = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Updated Details are as follows");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("UserName : " + u1.User_name);
                        Console.WriteLine("Passwd: " + u1.Passwd);
                        Console.WriteLine("Phone number: " + u1.Phone_num);
                        Console.WriteLine("Added date : " + u1.Date_Added);
                        Console.WriteLine();

                    }
                    else if (op == "No")
                    {

                        Console.WriteLine("UserName : " + u1.User_name);
                        Console.WriteLine("Passwd: " + u1.Passwd);
                        Console.WriteLine("Phone number: " + u1.Phone_num);
                        Console.WriteLine("Added date : " + u1.Date_Added);
                        Console.WriteLine();
                    }



                }
                else
                {
                    Console.WriteLine("Incorrect Passwd");
                }
            }
            else
            {
                Console.WriteLine("Invalid UserName");
            }
        }
    }
}