namespace Fima.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Data.DbModels;
    using Infrastructure.Mapping;
    using Models;
    using Web.Controllers;

    [Authorize(Roles = "администратор")]
    public class HomeController : BaseController
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

        [HttpGet]
        public ActionResult UserEdit(int id)
        {
            var entity = this.users.GetById(id);
            var model = this.Mapper.Map<FimaUsersViewModel>(entity);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UserEdit(FimaUsersViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var entity = this.users.GetById(model.Id);
            this.Mapper.Map(model, entity);
            this.users.Save();

            return this.View(model);
        }

        [HttpGet]
        public ActionResult RoleEdit(int id)
        {
            var entity = this.roles.GetById(id);
            var model = this.Mapper.Map<FimaRolesViewModel>(entity);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoleEdit(FimaRolesViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            var entity = this.roles.GetById(model.Id);
            this.Mapper.Map(model, entity);
            this.roles.Save();

            return this.View(model);
        }
    }
}
