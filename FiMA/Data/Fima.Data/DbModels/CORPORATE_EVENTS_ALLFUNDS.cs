
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
    
public partial class CORPORATE_EVENTS_ALLFUNDS
{

    public Nullable<System.DateTime> RECORD_DATE { get; set; }

    public Nullable<System.DateTime> EX_DATE { get; set; }

    public Nullable<System.DateTime> PAY_DATE { get; set; }

    public string POSITION_NAME { get; set; }

    public string POSITION_ISIN_EXISTING { get; set; }

    public string CURRENCY { get; set; }

    public Nullable<double> POSITION_QUANTITY_EXISTING { get; set; }

    public Nullable<double> POSITION_SP_EXISTING { get; set; }

    public Nullable<double> POSITION_SUMCCY_EXISTING { get; set; }

    public Nullable<double> POSITION_FX_EXISTING { get; set; }

    public Nullable<double> POSITION_SPBGN_EXISTING { get; set; }

    public Nullable<double> POSITION_SUMBGN_EXISTING { get; set; }

    public Nullable<double> AMOUNT_PERSHARE { get; set; }

    public Nullable<double> TAXES { get; set; }

    public Nullable<double> OTHER_CHARGES { get; set; }

    public string POSITION_ISIN_NEW { get; set; }

    public string POSITION_NAME_NEW { get; set; }

    public Nullable<double> POSITION_SP_NEW { get; set; }

    public Nullable<double> POSITION_QUANTITY_NEW { get; set; }

    public Nullable<double> POSITION_SUM_NEW { get; set; }

    public Nullable<double> POSITION_NEWPRICE_OLDSHARES { get; set; }

    public string CORPORATEECENT_DES { get; set; }

    public Nullable<System.DateTime> CE_DATE { get; set; }

    public double CE_UNIQUE_ID { get; set; }

    public Nullable<double> CE_FOLDER_ID { get; set; }

    public string CE_FOLDER_TYPE { get; set; }

    public string ATTACHMENT_PATH { get; set; }

    public string EVENT_TYPE { get; set; }

    public string CE_FUNDID { get; set; }

    public string CE_STATUS { get; set; }

}

}
