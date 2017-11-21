namespace Fima.Data.Models
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class FimaRoleStore : RoleStore<FimaRole, int, FimaUserRole>, IQueryableRoleStore<FimaRole, int>,
    IRoleStore<FimaRole, int>, IDisposable
    {
        public FimaRoleStore()
            : base(new IdentityDbContext())
        {
            base.DisposeContext = true;
        }

        public FimaRoleStore(DbContext context)
            : base(context)
        {
        }
    }
}
