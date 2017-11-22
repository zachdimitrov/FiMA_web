namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class LocalAddressViewModel
    {
        public string Region { get; set; }

        public string Street { get; set; }

        public int StreetNumber { get; set; }

        public int Floor { get; set; }

        public int Apartment { get; set; }

        public int LocalCountry { get; set; }

        public int LocalCity { get; set; }

        public int BirthCountry { get; set; }

        public int BirthCity { get; set; }
    }
}
