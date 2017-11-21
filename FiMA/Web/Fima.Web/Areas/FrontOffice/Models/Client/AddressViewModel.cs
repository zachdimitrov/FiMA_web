namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class AddressViewModel
    {
        public string Country { get; set; }

        public bool DualCitizen { get; set; }

        public string City { get; set; }

        public string Municipality { get; set; }

        public string Address { get; set; }
    }
}
