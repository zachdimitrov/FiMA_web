namespace Fima.Services.Data
{
    using System.Collections.Generic;
    using Fima.Data.DbModels;

    public interface IRolesService
    {
        IEnumerable<FimaRoles> AllButAdmin();
    }
}
