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
    
    public partial class NAV_FUNDS
    {
        public string NAV_BALANCED_ID { get; set; }
        public System.DateTime DATE_NAV_BALANCED { get; set; }
        public Nullable<double> NAV_ASSETVALUE_BALANCED { get; set; }
        public Nullable<double> NAV_BALANCED_NAV { get; set; }
        public Nullable<double> NAV_BALANCED_NAVSHARE { get; set; }
        public Nullable<double> NAV_BALANCED_ISUE1 { get; set; }
        public Nullable<double> NAV_BALANCED_ISSUE2 { get; set; }
        public Nullable<double> NAV_BALANCED_ISSUE3 { get; set; }
        public Nullable<double> NAV_BALANCED_ISSUE4 { get; set; }
        public Nullable<double> NAV_BALANCED_REDEMP1 { get; set; }
        public Nullable<double> NAV_BALANCED_REDEMP2 { get; set; }
        public Nullable<double> NAV_BALANCED_REDEMP3 { get; set; }
        public Nullable<double> NAV_BALANCED_SHARES { get; set; }
        public Nullable<double> NAV_PORTFOLIO_BG { get; set; }
        public Nullable<double> NAV_PORTFOLIO_FOR { get; set; }
        public string DOC_PATH_BD { get; set; }
        public string DOC_PATH_FSC { get; set; }
        public string DOC_PATH_NAVFILE { get; set; }
        public Nullable<int> WK_DAYS { get; set; }
        public string PRICE_DES { get; set; }
        public Nullable<int> WK_DAYS_ALL { get; set; }
        public Nullable<double> benchmark { get; set; }
        public string STATUS { get; set; }
        public Nullable<double> NAV_BALANCED_CURRENCY { get; set; }
    }
}
