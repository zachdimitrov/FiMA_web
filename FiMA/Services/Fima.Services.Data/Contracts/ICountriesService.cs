namespace Fima.Services.Data.Contracts
{
    using System.Collections.Generic;
    using Fima.Data.DbModels;

    public interface ICountriesService
    {
        IEnumerable<string> AllForeignCountryNames();

        IEnumerable<string> AllNames();

        COUNTRIES GetByName(string name);

        IEnumerable<string> GetNamesBasedOnPerType(string perType);

    }
}