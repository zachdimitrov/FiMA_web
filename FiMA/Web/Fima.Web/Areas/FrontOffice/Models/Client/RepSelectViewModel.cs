namespace Fima.Web.Areas.FrontOffice.Models.Client
{
    using System.ComponentModel.DataAnnotations;
    using Data.DbModels;
    using Infrastructure.Mapping;

    public class RepSelectViewModel : IMapTo<INVESTORS_FUNDS>, IMapFrom<INVESTORS_FUNDS>
    {
        [Required(ErrorMessage = "Въведете ЕГН или ЕИК!")]
        [RegularExpression("^[0-9]{9,13}$", ErrorMessage = "Въведете валидно ЕГН или ЕИК!")]
        [Display(Name = "ЕГН / Булстат")]
        public string PERSONALID_BULSTAT { get; set; }

        [Display(Name = "идентификатор")]
        public string CLIENTID_STRING { get; set; }

        [Display(Name = "име")]
        public string FULL_NAME { get; set; }

        [Display(Name = "държава")]
        public string COUNTRY_ADDRESS_ID { get; set; }

        [Display(Name = "град")]
        public string TOWN_ADDRESS_ID { get; set; }
    }
}