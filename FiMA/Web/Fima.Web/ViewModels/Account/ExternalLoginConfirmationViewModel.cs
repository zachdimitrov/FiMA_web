namespace Fima.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Е-мейл адрес")]
        public string Email { get; set; }
    }
}
