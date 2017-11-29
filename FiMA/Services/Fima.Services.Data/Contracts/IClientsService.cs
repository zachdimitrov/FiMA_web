namespace Fima.Services.Data.Contracts
{
    using System.Collections.Generic;
    using Fima.Data.DbModels;

    public interface IClientsService
    {
        INVESTORS_FUNDS FindByPersonalId(string personalId);

        IEnumerable<string> AllPersonalIds();

        void CreateClient(INVESTORS_FUNDS model);

        int GetNewId();
    }
}