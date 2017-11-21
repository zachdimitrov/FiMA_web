namespace Fima.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = false;
            this.AutomaticMigrationDataLossAllowed = false;
        }

        protected override void Seed(ApplicationDbContext context)
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
            var roleStore = new RoleStore<IdentityRole>(context);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            var adminRole = new IdentityRole { Name = "Administrator" };
            var subscriberRole = new IdentityRole { Name = "Subscriber" };
            var frontOfficeRole = new IdentityRole { Name = "FrontOffice" };
            var backOfficeRole = new IdentityRole { Name = "BackOffice" };
            var accauntingRole = new IdentityRole { Name = "Accountant" };
            var walletManagerRole = new IdentityRole { Name = "WalletManager" };
            var riskManagerRole = new IdentityRole { Name = "RiskManager" };

            roleManager.Create(adminRole);
            roleManager.Create(subscriberRole);
            roleManager.Create(frontOfficeRole);
            roleManager.Create(backOfficeRole);
            roleManager.Create(accauntingRole);
            roleManager.Create(walletManagerRole);
            roleManager.Create(riskManagerRole);

            var userStore = new UserStore<ApplicationUser>(context);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var user = new ApplicationUser
            {
                UserName = administratorUsername,
                Email = administratorEmail,
                EmailConfirmed = true,
                CreatedOn = DateTime.Now
            };

            userManager.Create(user, administratorPassword);
            userManager.AddToRole(user.Id, adminRole.Name);

            context.SaveChanges();
        }
    }
}
