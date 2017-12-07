namespace Fima.Services.Data.Contracts
{
    using System.Collections.Generic;

    public interface IBanksService
    {
        IEnumerable<string> AllNames();
    }
}
