//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fima.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DE_EXPENSES_ANYFUND
    {
        public double DE_ID { get; set; }
        public string DE_CPID { get; set; }
        public string DE_CPNAME { get; set; }
        public Nullable<System.DateTime> DE_DATE_BEGIN { get; set; }
        public Nullable<System.DateTime> DE_DATE_END { get; set; }
        public Nullable<double> DE_AMOUNT { get; set; }
        public Nullable<double> DE_DAYS { get; set; }
        public string DE_FUNDID { get; set; }
        public Nullable<double> ACOUNT_ASSET { get; set; }
        public Nullable<double> ACCOUNT_LB { get; set; }
        public Nullable<double> ACCOUNT_EXPENSE { get; set; }
        public Nullable<double> DE_AMOUNT_MONTH { get; set; }
        public Nullable<int> DE_DAYS_MONTH { get; set; }
    }
}
