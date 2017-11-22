using System.Data.Entity;
using Fima.Common;
using Fima.Data;
using Fima.Data.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fima.Web.Startup))]

namespace Fima.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
            SeedData();
        }

        private static void SeedData()
        {
            var context = new ApplicationDbContext();
            const string administratorUsername = "admin";
            const string administratorEmail = "admin@fima.com";
            const string administratorPassword = "123qwe";

            SeedAdmin(
            context,
            administratorUsername,
            administratorEmail,
            administratorPassword);
        }

        private static void SeedAdmin(
            DbContext context,
            string administratorUsername,
            string administratorEmail,
            string administratorPassword)
        {
            // create roles for all other users here
            var roleStore = new Fima.Data.Models.FimaRoleStore(context);
            var roleManager = new RoleManager<FimaRole, int>(roleStore);

            if (roleManager.RoleExists(GlobalConstants.AdministratorRoleName))
            {
                return;
            }

            var adminRole = new FimaRole { Name = GlobalConstants.AdministratorRoleName};
            var guestRole = new FimaRole { Name = GlobalConstants.GuestRoleName };
            var frontOfficeRole = new FimaRole { Name = GlobalConstants.FrontOfficeRoleName };
            var backOfficeRole = new FimaRole { Name = GlobalConstants.BackOfficeRoleName };
            var accauntingRole = new FimaRole { Name = GlobalConstants.AccountantRoleName };
            var walletManagerRole = new FimaRole { Name = GlobalConstants.WalletManagerRoleName };
            var riskManagerRole = new FimaRole { Name = GlobalConstants.RiskManagerRoleName };

            roleManager.Create(adminRole);
            roleManager.Create(guestRole);
            roleManager.Create(frontOfficeRole);
            roleManager.Create(backOfficeRole);
            roleManager.Create(accauntingRole);
            roleManager.Create(walletManagerRole);
            roleManager.Create(riskManagerRole);

            var userStore = new Fima.Data.Models.FimaUserStore(context);
            var userManager = new UserManager<FimaUser, int>(userStore);

            var user = new FimaUser
            {
                UserName = administratorUsername,
                Email = administratorEmail,
                EmailConfirmed = true
            };

            userManager.Create(user, administratorPassword);
            userManager.AddToRole(user.Id, adminRole.Name);

            context.SaveChanges();
        }
    }
}
