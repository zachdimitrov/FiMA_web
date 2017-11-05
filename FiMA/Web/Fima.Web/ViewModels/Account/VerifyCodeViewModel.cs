namespace Fima.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required(ErrorMessage = "Моля въведете код за потвърждение!")]
        [Display(Name = "Код за потвърждение")]
        public string Code { get; set; }

        public string ReturnUrl { get; set; }

        [Display(Name = "Запомнете в браузъра?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }
}
