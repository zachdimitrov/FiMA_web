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
    
    public partial class INVESTORSORDERS_ANYFUND2
    {
        public double ORDER_ID { get; set; }
        public string INVESTOR { get; set; }
        public string INVESTOR_ID { get; set; }
        public string ORDER_TYPE { get; set; }
        public Nullable<System.DateTime> DATE_TIME { get; set; }
        public string ORD_TIME { get; set; }
        public Nullable<System.DateTime> DATE_DEAL { get; set; }
        public Nullable<System.DateTime> DATE_PRICE { get; set; }
        public string ORDER_FUND { get; set; }
        public Nullable<double> ORDER_SUM { get; set; }
        public string ORDER_CURRENCY { get; set; }
        public Nullable<double> ORDER_SHARES { get; set; }
        public string STATUS { get; set; }
    }
}
