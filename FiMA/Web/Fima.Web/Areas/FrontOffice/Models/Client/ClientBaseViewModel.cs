namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ClientBaseViewModel
    {
        public string Identification { get; set; }

        public string EntityType { get; set; }

        public string Employee { get; set; }

        public string CdRegistration { get; set; }
    }
}