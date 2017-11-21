namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class LegalEntityViewModel
    {
        public string Name { get; set; }

        public string TaxNumber { get; set; }

        public string VatRegistration { get; set; }

        public string LegalType { get; set; }
    }
}