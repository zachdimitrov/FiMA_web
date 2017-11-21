using System.Data.Entity;
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
        private ApplicationDbContext context;

        public Startup(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Configuration(IAppBuilder app)
        {
            this.ConfigureAuth(app);
            this.SeedData(this.context);
        }

        private void SeedData(ApplicationDbContext context)
        {
            const string AdministratorUsername = "admin";
            const string AdministratorEmail = "admin@fima.com";
            const string AdministratorPassword = "123qwe";

            this.SeedAdmin(
            context,
            AdministratorUsername,
            AdministratorEmail,
            AdministratorPassword);
        }

        private void SeedAdmin(
            ApplicationDbContext context,
            string administratorUsername,
            string administratorEmail,
            string administratorPassword)
        {
            // create roles for all other users here
            var roleStore = new Fima.Data.Models.FimaRoleStore(context);
            var roleManager = new RoleManager<FimaRole, int>(roleStore);

            if (!roleManager.RoleExists("Administrator"))
            {
                var adminRole = new FimaRole { Name = "Administrator" };
                var subscriberRole = new FimaRole { Name = "Subscriber" };
                var frontOfficeRole = new FimaRole { Name = "FrontOffice" };
                var backOfficeRole = new FimaRole { Name = "BackOffice" };
                var accauntingRole = new FimaRole { Name = "Accountant" };
                var walletManagerRole = new FimaRole { Name = "WalletManager" };
                var riskManagerRole = new FimaRole { Name = "RiskManager" };

                roleManager.Create(adminRole);
                roleManager.Create(subscriberRole);
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
}
