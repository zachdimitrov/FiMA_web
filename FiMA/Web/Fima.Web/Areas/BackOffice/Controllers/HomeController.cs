namespace Fima.Web.Areas.BackOffice.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        // GET: FrontOffice/Home
        public ActionResult Index()
        {
            return this.View();
        }
    }
}
