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
    
    public partial class sp_getinvdeal_schroders2_Result
    {
        public Nullable<double> DEALS_ORDERID { get; set; }
        public Nullable<double> DEALS_ID_STRING { get; set; }
        public double DEALS_ID { get; set; }
        public string DEALS_INVESTOR { get; set; }
        public string DEALS_INVESTOR_NAME { get; set; }
        public string DEALS_TYPE { get; set; }
        public Nullable<System.DateTime> DATE_DEAL { get; set; }
        public Nullable<System.DateTime> deals_settlement { get; set; }
        public Nullable<double> DEALS_AMOUNT_CCY { get; set; }
        public Nullable<double> DEALS_AMOUNT { get; set; }
        public Nullable<double> DEALS_SHARES { get; set; }
        public Nullable<double> DEALS_PRICE { get; set; }
        public string DEALS_FUND { get; set; }
        public string DEALS_FUND_NAME { get; set; }
        public string DEALS_CURRENCY { get; set; }
        public string STATUS { get; set; }
        public Nullable<double> DEALS_NAVSHARE { get; set; }
        public string FEE { get; set; }
        public string invdeal_accounted { get; set; }
        public Nullable<System.DateTime> DATE_ORDER { get; set; }
        public string doc_confirm { get; set; }
    }
}
