namespace Fima.Services.Data.Contracts
{
    using System.Collections.Generic;
    using System.Linq;
    using Fima.Data.DbModels;

    public interface IClientsService
    {
        INVESTORS_FUNDS FindByPersonalId(string personalId);

        IEnumerable<string> AllPersonalIds();

        IQueryable<INVESTORS_FUNDS> GetAll();

        void CreateClient(INVESTORS_FUNDS model);

        int GetNewId();
    }
}