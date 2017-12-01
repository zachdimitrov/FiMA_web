namespace Fima.Services.Data.Client
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Fima.Data.DbModels;

    public class ClientsService : BaseDataService<INVESTORS_FUNDS>, IClientsService
    {
        public ClientsService(IFimaRepository<INVESTORS_FUNDS> clients)
            : base(clients)
        {
        }

        public INVESTORS_FUNDS FindByPersonalId(string personalId)
        {
            return this.GetAll()
                .Where(x => x.PERSONALID_BULSTAT == personalId)
                .FirstOrDefault();
        }

        public IEnumerable<string> AllPersonalIds()
        {
            return this.GetAll()
                .Select(x => x.PERSONALID_BULSTAT)
                .ToList();
        }

        public void CreateClient(INVESTORS_FUNDS model)
        {
            this.Add(model);
        }

        public int GetNewId()
        {
            int currentMax = this.GetAll()
                .Select(x => x.CLIENTID)
                .Max();

            return ++currentMax;
        }

        IQueryable<INVESTORS_FUNDS> IClientsService.GetAll()
        {
            return this.GetAll();
        }
    }
}
