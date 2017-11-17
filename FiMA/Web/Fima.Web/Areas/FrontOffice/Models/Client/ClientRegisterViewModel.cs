namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ClientRegisterViewModel
    {
        // base properties
        public ClientBaseViewModel BaseFields { get; set; }

        // individual
        public IndividualViewModel Individual { get; set; }

        // legal entity
        public LegalEntityViewModel LegalEntity { get; set; }

        // address
        public AddressViewModel Address { get; set; }

        // local address
        public LocalAddressViewModel LocalAddress { get; set; }

        // attorneys
        public IEnumerable<AttorneyViewModel> Attorneys { get; set; }

        // bank accounts
        public IEnumerable<BankAccountViewModel> BankAccounts { get; set; }

        // other data
        // attorney data
    }
}
