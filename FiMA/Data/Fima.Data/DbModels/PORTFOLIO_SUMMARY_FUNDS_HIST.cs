
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
    
public partial class PORTFOLIO_SUMMARY_FUNDS_HIST
{

    public System.DateTime DATE { get; set; }

    public double TRANSACTION_ACCOUNT { get; set; }

    public string NAME { get; set; }

    public string ISIN_CODE { get; set; }

    public string CURRENCY { get; set; }

    public Nullable<double> SUM_QUANTITY { get; set; }

    public Nullable<double> PRICE { get; set; }

    public Nullable<double> SUM_CCY { get; set; }

    public Nullable<double> FX { get; set; }

    public Nullable<double> SP_BGN { get; set; }

    public Nullable<double> SUM_BGN { get; set; }

    public string MYFUNDID { get; set; }

    public Nullable<System.DateTime> EFFECTIVE_DATE { get; set; }

    public string USER_ID { get; set; }

    public string ACT_EVENT { get; set; }

}

}
