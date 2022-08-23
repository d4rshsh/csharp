namespace IncrementalAssignment
{
    internal class Prob16
    {
        static void Main(string[] args)
        {
            string first_name, last_name;
            Console.WriteLine("Enter your first name");
            first_name = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            last_name = Console.ReadLine();
            string user_name, pwd;
            Console.WriteLine("Enter uname");
            user_name = Console.ReadLine();
            Console.WriteLine("Password");
            pwd = Console.ReadLine();
            if ((first_name == user_name) && (last_name == pwd) && (!String.IsNullOrEmpty(user_name)) && (!String.IsNullOrEmpty(pwd)))
                Console.WriteLine("Welcome to my app" + " " + first_name + " " + last_name);
            else
            {

                if (first_name != user_name && last_name != pwd)
                    Console.WriteLine("Invalid Credentials");
                else if (first_name != user_name)
                    Console.WriteLine("uname unmatched");
                else if ((String.IsNullOrEmpty(user_name)) || (String.IsNullOrEmpty(pwd)))
                    Console.WriteLine("Username or password can't be null");
                else
                    Console.WriteLine("Invalid Password");

            }
            Console.ReadLine();
        }
    }
