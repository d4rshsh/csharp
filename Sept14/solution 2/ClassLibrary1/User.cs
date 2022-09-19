using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept14
{
    public class Users
    {

        public string User_name { get; set; }
        public string Passwd { get; set; }

        private string _phno;

        public string Phone_num
        {
            get { return _phno; }
            set { _phno = value; }
        }
        public DateTime Date_Added { get; set; }


        public void RegisterUser(Users user, List<Users> useslist)
        {
            Console.WriteLine("Enter User name");
            user.User_name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            user.Passwd = Console.ReadLine();
            user.Date_Added = DateTime.Now;
            Console.WriteLine("Enter Phone Number");
            user.Phone_num = Console.ReadLine();
            Users check = useslist.Find(X => X.Phone_num == user.Phone_num);
            if (check == null)
            {
                useslist.Add(user);

            }
            else
            {
                Console.WriteLine("Already subscribed");
            }
            Console.WriteLine("You have registered on" + user.Date_Added);
            Console.WriteLine("User name : " + user.User_name);
            Console.WriteLine("Password : " + user.Passwd);
            Console.WriteLine("Phone : " + user.Phone_num);
            Console.WriteLine();
            foreach (Users u in useslist)
            {
                Console.WriteLine("User name : " + u.User_name);
                Console.WriteLine("Password : " + u.Passwd);
                Console.WriteLine("Phone : " + u.Phone_num);
                Console.WriteLine("Registered Date : " + u.Date_Added);

            }


        }

        public void EditUserData(Users user, List<Users> useslist)
        {
            Console.WriteLine("Enter Phone Number");
            user.Phone_num = Console.ReadLine();
            Users check = useslist.Find(X => X.Phone_num == user.Phone_num);
            if (check != null)
            {
                Console.WriteLine("Enter User name");
                check.User_name = Console.ReadLine();
                Console.WriteLine("Enter Password");
                check.Passwd = Console.ReadLine();
                check.Date_Added = DateTime.Now;
                Console.WriteLine("Enter Phone Number");
                check.Phone_num = Console.ReadLine();
                
                Console.WriteLine("User details edited on " + check.Date_Added);
                Console.WriteLine("User name : " + check.User_name);
                Console.WriteLine("Password : " + check.Passwd);
                Console.WriteLine("Phone : " + check.Phone_num);
                Console.WriteLine();
                
                foreach (Users u in useslist)
                {
                    Console.WriteLine("User_name : " + u.User_name);
                    Console.WriteLine("Passwd : " + u.Passwd);
                    Console.WriteLine("Phone : " + u.Phone_num);
                    Console.WriteLine("Registered Time : " + u.Date_Added);

                }

            }
            else
            {
                Console.WriteLine("User not Found");
            }

        }
    }
}


