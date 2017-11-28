namespace Fima.Services.Data.Contracts
{
    using System.Collections.Generic;
    using Fima.Data.DbModels;

    public interface IRolesService
    {
        IEnumerable<string> AllButAdmin();
    }
}
