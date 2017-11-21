namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class IndividualViewModel
    {
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public string IdNumber { get; set; }

        public DateTime IdReleaseDate { get; set; }

        public string IdReleaseLocation { get; set; }
    }
}
