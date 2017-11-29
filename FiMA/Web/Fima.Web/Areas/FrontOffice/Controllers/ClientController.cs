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
        private readonly IClientsService clients;
        private readonly IMunicipalitiesService municipalities;
        private readonly IBanksService banks;

        public ClientController(
            ICountriesService countries,
            ICitiesService cities,
            IClientsService clients,
            IMunicipalitiesService municipalities,
            IBanksService banks)
        {
            this.countries = countries;
            this.cities = cities;
            this.clients = clients;
            this.municipalities = municipalities;
            this.banks = banks;
        }

        // for ajax request
        [HttpGet]
        public JsonResult GetClients()
        {
            var users = this.userService
                .GetAll()
                .Select(u => u.UserName)
                .ToList();

            return Json(users, JsonRequestBehavior.AllowGet);
        }

        // GET: FrontOffice/Client/Register
        [HttpGet]
        public ActionResult Register()
        {
            var model = new ClientRegisterViewModel();

            model.Countries = this.countries.AllNames();
            model.Cities = this.cities.AllNames();
            model.Banks = this.banks.AllNames();
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
