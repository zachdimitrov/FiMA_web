namespace Fima.Web.Areas.FrontOffice
{
    using System.Web.Mvc;

    public class FrontOfficeAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "FrontOffice";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                name: "FrontOffice_default",
                url: "FrontOffice/{controller}/{action}/{id}",
                defaults: new { action = "Index", id = UrlParameter.Optional },
                namespaces: new string[] { "Fima.Web.Areas.FrontOffice.Controllers" });
        }
    }
}
