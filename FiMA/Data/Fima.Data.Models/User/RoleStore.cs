namespace Fima.Data.Models
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class RoleStore : RoleStore<FimaRole, int, FimaUserRole>
    {
        public RoleStore(DbContext context)
            : base(context)
        {
        }
    }
}
