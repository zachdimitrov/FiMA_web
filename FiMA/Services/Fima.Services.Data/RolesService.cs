namespace Fima.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Fima.Common;
    using Fima.Data.Common;
    using Fima.Data.DbModels;

    public class RolesService : BaseDataService<FimaRoles>, IRolesService
    {
        public RolesService(IFimaRepository<FimaRoles> roles)
            : base(roles)
        {
        }

        public IEnumerable<string> AllButAdmin()
        {
            return this.GetAll()
                .Where(n => n.Name != GlobalConstants.AdministratorRoleName)
                .Select(r => r.Name)
                .ToList();
        }

        public IEnumerable<string> AllButSelected(string role)
        {
            return this.GetAll()
                .Where(n => n.Name != role)
                .Select(r => r.Name)
                .ToList();
        }
    }
}
