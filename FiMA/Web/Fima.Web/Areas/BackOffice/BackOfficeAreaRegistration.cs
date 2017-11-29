namespace Fima.Web.Areas.BackOffice
{
    using System.Web.Mvc;

    public class BackOfficeAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "BackOffice";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.Routes.LowercaseUrls = true;
            context.MapRoute(
                    name: "BackOffice_default",
                    url: "BackOffice/{controller}/{action}/{id}",
                    defaults: new { action = "Index", id = UrlParameter.Optional },
                    namespaces: new string[] { "Fima.Web.Areas.BackOffice.Controllers" });
        }
    }
}
