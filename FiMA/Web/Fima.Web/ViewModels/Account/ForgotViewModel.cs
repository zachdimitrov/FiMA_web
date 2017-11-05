namespace Fima.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Е-мейл адрес")]
        public string Email { get; set; }
    }
}
