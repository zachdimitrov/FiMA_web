namespace Fima.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Е-мейл адресът е задължителен!")]
        [EmailAddress(ErrorMessage = "Е-мейл адресът не е валиден!")]
        [Display(Name = "Е-мейл адрес")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Паролата е задължителна!")]
        [StringLength(100, ErrorMessage = "Паролата трябва да е поне {2} символа.", MinimumLength = Common.GlobalConstants.PasswordMinLength)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърдете паролата")]
        [Compare("Password", ErrorMessage = "Паролата не съпада, моля опитайте отново!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Код за потвърждение")]
        public string Code { get; set; }
    }
}
