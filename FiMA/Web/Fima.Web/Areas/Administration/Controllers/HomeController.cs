namespace Fima.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Data.DbModels;
    using Infrastructure.Mapping;
    using Models;

    public class HomeController : Controller
    {
        private readonly IFimaRepository<FimaUsers> users;
        private readonly IFimaRepository<FimaRoles> roles;

        public HomeController(IFimaRepository<FimaUsers> users, IFimaRepository<FimaRoles> roles)
        {
            this.users = users;
            this.roles = roles;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Users()
        {
            var usersModel = this.users.All()
                .To<FimaUsersViewModel>()
                .ToList();

            return this.View(usersModel);
        }

        public ActionResult Roles()
        {
            var rolesModel = this.roles.All()
                .To<FimaRolesViewModel>()
                .ToList();

            return this.View(rolesModel);
        }
    }
}
