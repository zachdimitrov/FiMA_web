
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Fima.Data.DbModels
{

using System;
    using System.Collections.Generic;
    
public partial class DEPOSITS_ALLFUNDS
{

    public double DEPOSIT_ID { get; set; }

    public Nullable<System.DateTime> DATE_DEPOSIT_OPEN { get; set; }

    public Nullable<System.DateTime> DATE_DEPOSIT_ACCRINT { get; set; }

    public Nullable<System.DateTime> DATE_DEPOSIT_MATURITY { get; set; }

    public Nullable<System.DateTime> DATE_DEPOSIT_END_INTACCR { get; set; }

    public Nullable<double> DEP_ACCOUNT { get; set; }

    public string DEPOSIT_CCY { get; set; }

    public Nullable<double> DEPOSIT_AMOUNT { get; set; }

    public Nullable<double> DEPOSIT_INTEREST { get; set; }

    public string DEPOSIT_CONVENTION { get; set; }

    public string DEPOSIT_WITH_BANK { get; set; }

    public string DEPOSIT_FUND_ID { get; set; }

    public string DEPOSIT_DES { get; set; }

    public string DEPOSIT_ATTACHMENT_PATH { get; set; }

    public string BANK_ACCOUNT { get; set; }

    public Nullable<short> DEP_CONV_DAYS { get; set; }

    public Nullable<short> DEP_CONV_DAYS_SMALL { get; set; }

    public Nullable<int> DEP_CONV_DAYS_CURRENT { get; set; }

    public Nullable<System.DateTime> DATE_LAST_ACCRUED { get; set; }

    public string DEP_STATUS { get; set; }

}

}
