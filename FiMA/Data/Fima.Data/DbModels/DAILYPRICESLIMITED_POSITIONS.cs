
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
    
public partial class DAILYPRICESLIMITED_POSITIONS
{

    public Nullable<System.DateTime> DATE { get; set; }

    public string ISIN { get; set; }

    public string TICKER1 { get; set; }

    public string NAME_BG { get; set; }

    public string CURRENCY { get; set; }

    public Nullable<double> LAST_PRICE { get; set; }

    public Nullable<System.DateTime> DATE_LAST_PRICE { get; set; }

    public Nullable<double> QUANTITY_TRADED { get; set; }

    public Nullable<double> BEST_BID { get; set; }

    public Nullable<double> QUANTIY_BEST_BID { get; set; }

    public Nullable<double> BEST_ASK { get; set; }

    public Nullable<double> QUANTITY_BEST_ASK { get; set; }

    public Nullable<double> AVERAGE_PRICE { get; set; }

    public Nullable<double> OTHERPRICE { get; set; }

    public string DES_OTHERPRICE { get; set; }

    public string FUND { get; set; }

    public Nullable<int> PAR { get; set; }

    public string TYPE { get; set; }

    public Nullable<double> NUMBERSHARES_OUT { get; set; }

}

}
