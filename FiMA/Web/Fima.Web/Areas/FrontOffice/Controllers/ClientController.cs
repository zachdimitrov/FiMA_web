namespace Fima.Web.Areas.FrontOffice.Controllers
{
    using System.Web.Mvc;
    using Models.Client;

    public class ClientController : Controller
    {
        // GET: FrontOffice/Client/Register
        [HttpGet]
        public ActionResult Register()
        {
            return this.View();
        }

        // POST: FrontOffice/Client/Register
        [HttpPost]
        public ActionResult Register(ClientRegisterViewModel model)
        {
            return this.View(model);
        }
    }
}
