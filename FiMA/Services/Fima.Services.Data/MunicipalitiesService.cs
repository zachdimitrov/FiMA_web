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

        public int Add(string mun)
        {
            if (this.AllNames().Contains(mun))
            {
                return 0;
            }

            var m = new MUNICIPALITY()
            {
                MUNICIPALITY1 = mun
            };

            this.Add(m);
            return 1;
        }
    }
}
