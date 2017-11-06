namespace Fima.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class ExternalLoginConfirmationViewModel
    {
        [Required(ErrorMessage = "Е-мейл адресът е задължителен!")]
        [EmailAddress(ErrorMessage = "Е-мейл адресът не е валиден!")]
        [Display(Name = "Е-мейл адрес")]
        public string Email { get; set; }
    }
}
