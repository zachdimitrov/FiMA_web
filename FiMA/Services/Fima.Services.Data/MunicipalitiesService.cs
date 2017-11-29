namespace Fima.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Fima.Data.DbModels;

    public class MunicipalitiesService : BaseDataService<MUNICIPALITY>, IMunicipalitiesService
    {
        public MunicipalitiesService(IFimaRepository<MUNICIPALITY> municipalities)
            : base(municipalities)
        {
        }

        public IEnumerable<string> AllNames()
        {
            return this.GetAll()
                .Select(x => x.MUNICIPALITY1)
                .ToList();
        }
    }
}
