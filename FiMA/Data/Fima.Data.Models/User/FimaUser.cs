namespace Fima.Data.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class FimaUser : IdentityUser<int, FimaLogin, FimaUserRole, FimaClaim>, IUser<int>
    {
        public string StrEmpPassword { get; set; }

        public string StrAccess { get; set; }

        public string StrName { get; set; }

        public string StrTown { get; set; }

        public string StrIndex { get; set; }

        public string EmpFunction { get; set; }

        public string Emptown { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<FimaUser, int> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            // Add custom user claims here
            return userIdentity;
        }
    }
}
