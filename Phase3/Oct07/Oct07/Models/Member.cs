//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oct07.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public decimal MemberId { get; set; }
        public string Member_Name { get; set; }
        public Nullable<System.DateTime> Acc_Open_Date { get; set; }
        public Nullable<decimal> Max_Book_sAllowed { get; set; }
        public Nullable<decimal> Penalty_Amount { get; set; }
    }
}
