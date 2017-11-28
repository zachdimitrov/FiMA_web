namespace Fima.Services.Data.Contracts
{
    using Fima.Data.DbModels;

    public interface IClientsService
    {
        INVESTORS_FUNDS FindByPersonalId(string personalId);
    }
}