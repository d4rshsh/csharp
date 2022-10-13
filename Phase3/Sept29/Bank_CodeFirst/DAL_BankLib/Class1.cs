using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DAL_BankLib
{
    public class Borrower
    { 
        [Key]
        [Required]
        public int Borrower_ID { get; set; }
        public string Borrower_Name { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Company_Name { get; set; }
        public string Job_Name { get; set; }
        
        public virtual ICollection<Loan> Loans { get; set; }
    }
    public class Loan
    {
        [Key]
        [Required]
        public int Loan_ID { get; set; }
        public string Loan_Type { get; set; }
        public int Amount { get; set; }
        public int Duration { get; set; }
        public int RateOfInterest { get; set; }
        public int Borrower_ID { get; set; }

        [ForeignKey("Borrower_ID")]
        public virtual Borrower BorrowerDetails { get; set; }
    }
    public class MyBank : DbContext
    {
        public MyBank() : base("MyBank")
        {
            Database.SetInitializer<MyBank>(new DropCreateDatabaseIfModelChanges<MyBank>());
        }
        public virtual DbSet<Borrower> BorrowerTable { get; set; }
        public virtual DbSet<Loan> LoanTable { get; set; }
    }
}
