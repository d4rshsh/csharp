using DAL_BankLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBank context = new MyBank();
            context.BorrowerTable.Add(new Borrower
            {
                Borrower_ID = 1,
                Borrower_Name = "Sonia",
                Company_Name = "Bosch",
                Job_Name = "Senior Manager",
                City = "Chennai",
                State = "Tamil Nadu",
                Country = "India",
                Street = "Anna Nagar"
            });
            context.SaveChanges();
            Console.WriteLine("Added");
            Console.ReadLine();
        }
    }
}
