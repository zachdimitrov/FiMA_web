namespace Fima.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Fima.Common;
    using Fima.Data.DbModels;

    public class CountriesService : BaseDataService<COUNTRIES>, ICountriesService
    {
        public CountriesService(IFimaRepository<COUNTRIES> countries)
            : base(countries)
        {
        }

        public COUNTRIES GetByName(string name)
        {
            var lowerName = name.ToLower();

            return this.GetAll()
                .Where(x => x.COUNTRY.ToLower() == lowerName)
                .FirstOrDefault();
        }

        public IEnumerable<string> AllNames()
        {
            return this.GetAll()
                .Select(x => x.COUNTRY)
                .ToList();
        }

        public IEnumerable<string> AllForeignCountryNames()
        {
            return this.GetAll()
                .Select(x => x.COUNTRY)
                .Where(c => c.ToLower() != GlobalConstants.BaseCountry.ToLower())
                .ToList();
        }

        public IEnumerable<string> GetNamesBasedOnPerType(string perType)
        {
            if (perType == GlobalConstants.PerTypes[0] || perType == GlobalConstants.PerTypes[1])
            {
                return new List<string>() { GlobalConstants.BaseCountry };
            }

            return this.AllForeignCountryNames();
        }
    }
}
