/*
create a enum of deptnames as Purchase=1,Sales=2,Training=3 and Accounts=4.
Accept deptname as string and display deptnos.
 */

    internal class Program
    {
        static void Main(string[] args)
        {
            string dept_name = " ";
            Console.WriteLine("Enter deptname");
            dept_name = Console.ReadLine();
            int k;

            switch (dept_name)
            {
                case "Purchases":
                    k = (int)deptnames.Purchases;
                    Console.WriteLine(k);
                    break;
                case "Sales":
                    k = (int)deptnames.Sales;
                    Console.WriteLine(k);
                    break;
                case "Training":
                    k = (int)deptnames.Training;
                    Console.WriteLine(k);
                    break;
                case "Accounts":
                    k = (int)deptnames.Accounts;
                    Console.WriteLine(k);
                    break;
                default:
                    break;

            }

            Console.ReadLine();
        }
    }
    enum deptnames // ennumerated data type
    {
        Purchases = 1,
        Sales = 2,
        Training = 3,
        Accounts = 4
    }

