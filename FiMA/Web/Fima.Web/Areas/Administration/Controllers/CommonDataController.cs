namespace Fima.Web.Areas.Administration.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using Fima.Web.Controllers;

    [Authorize(Roles = "администратор")]
    public class CommonDataController : BaseController
    {
        // Countries
        // Banks
        // Towns
        // Municipalities
    }
}
