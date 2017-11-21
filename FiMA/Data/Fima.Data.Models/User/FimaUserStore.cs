namespace Fima.Data.Models
{
    using System;
    using System.Data.Entity;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class FimaUserStore : UserStore<FimaUser, FimaRole, int,
        FimaLogin, FimaUserRole, FimaClaim>, IUserStore<FimaUser, int>, IDisposable
    {
        public FimaUserStore()
            : this(new IdentityDbContext())
        {
            base.DisposeContext = true;
        }

        public FimaUserStore(DbContext context)
            : base(context)
        {
        }
    }
}
