namespace Fima.Web.Areas.FrontOffice.Controllers
{
    using System;
    using System.Web.Mvc;
    using Models.Client;
    using Services.Data.Contracts;

    public class ClientController : Controller
    {
        private readonly ICountriesService countries;
        private readonly ICitiesService cities;
        private readonly IMunicipalitiesService municipalities;

        public ClientController(
            ICountriesService countries,
            ICitiesService cities,
            IMunicipalitiesService municipalities)
        {
            this.countries = countries;
            this.cities = cities;
            this.municipalities = municipalities;
        }

        // GET: FrontOffice/Client/Register
        [HttpGet]
        public ActionResult Register()
        {
            var model = new ClientRegisterViewModel();

            model.Countries = this.countries.AllNames();
            model.Cities = this.cities.AllNames();
            model.Municipalities = this.municipalities.AllNames();
            model.PERSONAL_ID_DATE = DateTime.Today.ToString("dd/MM/yyyy");
            model.CLIENT_BIRTHDATE = DateTime.Today.ToString("dd/MM/yyyy");

            return this.View(model);
        }

        // POST: FrontOffice/Client/Register
        [HttpPost]
        public ActionResult Register(ClientRegisterViewModel model)
        {
            return this.View(model);
        }
    }
}
