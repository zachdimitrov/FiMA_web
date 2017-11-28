namespace Fima.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Fima.Data.DbModels;

    public class CitiesService : BaseDataService<TOWNS>, ICitiesService
    {
        public CitiesService(IFimaRepository<TOWNS> cities)
            : base(cities)
        {
        }

        public IEnumerable<string> AllNames()
        {
            return this.GetAll()
                .Select(x => x.TOWNNAME)
                .ToList();
        }
    }
}
