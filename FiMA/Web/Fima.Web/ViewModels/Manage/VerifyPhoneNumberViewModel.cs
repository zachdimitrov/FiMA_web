namespace Fima.Web.ViewModels.Manage
{
    using System.ComponentModel.DataAnnotations;

    public class VerifyPhoneNumberViewModel
    {
        [Required(ErrorMessage = "Моля, въведете кода за потърждение!")]
        [Display(Name = "Код за потвърждение")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Моля, въведете телефонен номер!")]
        [Phone]
        [Display(Name = "Телефонен номер")]
        public string PhoneNumber { get; set; }
    }
}
