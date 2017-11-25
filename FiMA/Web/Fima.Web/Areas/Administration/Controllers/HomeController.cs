namespace Fima.Web.Areas.Administration.Controllers
{
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
            FimaRolesViewModel model = this.Mapper.Map<FimaRolesViewModel>(entity);
            model.Users = this.users.All()
                .Where(x => !x.FimaRoles.Select(y => y.Name).ToList().Contains(model.Name))
                .Select(x => x.UserName)
                .ToList();

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult RoleEdit(string met, int id, FimaRolesViewModel model)
        {
            var entity = this.roles.GetById(id);

            if (met == null || model.FimaUsers.Count() <= 0)
            {
                FimaRolesViewModel m = this.Mapper.Map<FimaRolesViewModel>(entity);
                m.Users = this.users.All()
                    .Where(x => !x.FimaRoles.Select(y => y.Name).ToList().Contains(m.Name))
                    .Select(x => x.UserName)
                    .ToList();

                return this.View(m);
            }

            if (met == "add")
            {
                foreach (var userName in model.FimaUsers)
                {
                    var user = this.users.All()
                        .Where(u => u.UserName == userName)
                        .FirstOrDefault();

                    if (user != null)
                    {
                        entity.FimaUsers.Add(user);
                    }
                }
            }
            else if (met == "remove")
            {
                foreach (var userName in model.FimaUsers)
                {
                    var user = this.users.All()
                        .Where(u => u.UserName == userName)
                        .FirstOrDefault();

                    if (user != null && entity.FimaUsers.Contains(user))
                    {
                        entity.FimaUsers.Remove(user);
                    }
                }
            }

            this.roles.Save();

            return this.RedirectToAction("Roles");
        }
    }
}
