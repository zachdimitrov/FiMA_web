namespace Fima.Data.Models
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class UserStore : UserStore<FimaUser, FimaRole, int,
        FimaLogin, FimaUserRole, FimaClaim>
    {
        public UserStore(DbContext context)
            : base(context)
        {
        }
    }
}
