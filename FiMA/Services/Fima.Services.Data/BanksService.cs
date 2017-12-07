namespace Fima.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Fima.Data.DbModels;

    public class BanksService : BaseDataService<BANKS>, IBanksService
    {
        public BanksService(IFimaRepository<BANKS> dataSet)
            : base(dataSet)
        {
        }

        public IEnumerable<string> AllNames()
        {
            return this.GetAll()
                .Select(x => x.BANK_NAME)
                .ToList();
        }
    }
}
