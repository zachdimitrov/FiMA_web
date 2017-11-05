namespace Fima.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Потребителското име е задължително!")]
        [Display(Name = "Потребител")]
        [StringLength(50, ErrorMessage = "Потребителското име трябва да е поне {2} символа.", MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Е-мейл адресът е задължителен!")]
        [EmailAddress]
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
    }
}
