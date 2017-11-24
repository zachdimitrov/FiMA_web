namespace Fima.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using Fima.Common;
    using Fima.Data.DbModels;

    public class RolesService : IRolesService
    {
        private readonly IFimaRepository<FimaRoles> roles;

        public RolesService(IFimaRepository<FimaRoles> roles)
        {
            this.roles = roles;
        }

        public IEnumerable<string> AllButAdmin()
        {
            return this.roles.All()
                .Where(n => n.Name != GlobalConstants.AdministratorRoleName)
                .Select(r => r.Name)
                .ToList();
        }

        public IEnumerable<string> AllButSelected(string role)
        {
            return this.roles.All()
                .Where(n => n.Name != role)
                .Select(r => r.Name)
                .ToList();
        }
    }
}
