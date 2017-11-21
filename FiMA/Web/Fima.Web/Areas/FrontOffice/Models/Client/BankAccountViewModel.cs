namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class BankAccountViewModel
    {
        public string Iban { get; set; }

        public string Bic { get; set; }

        public string BankName { get; set; }
    }
}