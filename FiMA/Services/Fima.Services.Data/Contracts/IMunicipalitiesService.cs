namespace Fima.Services.Data.Contracts
{
    using System.Collections.Generic;

    public interface IMunicipalitiesService
    {
        IEnumerable<string> AllNames();
    }
}