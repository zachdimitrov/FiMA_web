namespace Fima.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Е-мейл адрес")]
        public string Email { get; set; }
    }
}
