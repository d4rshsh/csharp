using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Movies;

namespace AdminModule
{

    public class Admin : User
    {
        public Admin()
        {

            Read();
            User.Request += Request1;
        }
        public List<User> UserList = new List<User>();
        public void AddUserByAdmin()
        {
            FileStream fs = new FileStream("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\User.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(fs);
                Console.WriteLine("Enter User Name : ");
                string UserName = Console.ReadLine();
                Console.WriteLine("Enter User Id: ");
                string UserId = Console.ReadLine();
                Console.WriteLine("Enter User Password");
                string password = Console.ReadLine();
                Console.WriteLine("Enter user Level (2 or 3 or 5) : ");
                string level = Console.ReadLine();
                sw.WriteLine(UserName + "-" + UserId + "-" + password + "-" + level);
                Console.WriteLine("User Added Successfully..");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message : " + ex.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
                fs.Dispose();
            }
        }
        public void Read()
        {
            FileStream fs = new FileStream("C:\\Users\\sures\\source\\repos\\User.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            while (!sw.EndOfStream)
            {
                var data = sw.ReadLine().Split('-');
                User u = new User();
                u.UserName = data[0];
                u.UserId = long.Parse(data[1]);
                u.Password = data[2];
                u.userLevel = Int32.Parse(data[3]);
                UserList.Add(u);
            }
            foreach (var item in UserList)
            {
                Console.WriteLine("User Id : " + item.UserId);
            }
            sw.Close();
            fs.Close();
            fs.Dispose();
        }
        public void UpdateData(string UserId)
        {
            FileStream fs = new FileStream("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\User.txt", FileMode.Append, FileAccess.Write);
            StreamReader sr = new StreamReader("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\User.txt");
            while (!sr.EndOfStream)
            {
                var s = sr.ReadLine().Split('-')[1].Equals(UserId);
                if (s)
                {

                    sr.Close();
                    //  fs.Close();
                    StreamWriter sw = new StreamWriter(fs);
                    Console.WriteLine("Enter User Name-uaerid-password-userlevel(2,3,5) : ");
                    string ans = Console.ReadLine();
                    sw.WriteLine(ans);
                    break;
                }
            }
            sr.Close();
            //  fs.Close();
        }
        //public void UpdateUserData(string UserId)
        //{
        //    StreamReader reader = new StreamReader(@"D:\c#\MovieApps\AdminModule\bin\Debug\User.txt");
        //    string readedData = reader.ReadToEnd();
        //    reader.Close();
        //    Console.WriteLine("Enter UserID : ");
        //    string ans = Console.ReadLine();
        //    //modify what you want
        //    string v =readedData.Replace(UserId, ans);
        //    Console.WriteLine(v);
        //    //Write new file or append on existing file
        //    StreamWriter writer = new StreamWriter(@"D:\c#\MovieApps\AdminModule\bin\Debug\User.txt");
        //    writer.Write(v);
        //    writer.Close();
        //}
        public void WriteMovies()
        {
            Console.WriteLine("Enter Movie Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Lang : ");
            string UserId = Console.ReadLine();
            Console.WriteLine("Enter Genre : ");
            string Genre = Console.ReadLine();
            Console.WriteLine("Enter Cost : ");
            string cost = Console.ReadLine();
            string data = name + "-" + UserId + "-" + Genre + "-" + cost;
            FileStream fs = new FileStream("D:\\c#\\MovieApps\\AdminModule\\bin\\Debug\\MoviesList.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(data);
            sw.Close();
            fs.Close();
            fs.Dispose();
        }
        public static bool Request1(string s)
        {
            Console.WriteLine($"Admin : Enter yes or no to approve {s}");
            string ans = Console.ReadLine();
            if (ans == "yes" || ans == "YES")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}