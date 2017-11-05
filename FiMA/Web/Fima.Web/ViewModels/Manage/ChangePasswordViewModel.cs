namespace Fima.Web.ViewModels.Manage
{
    using System.ComponentModel.DataAnnotations;

    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Паролата е задължителна!")]
        [DataType(DataType.Password)]
        [Display(Name = "Вашата стара парола")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Моля, въведете новата парола!")]
        [StringLength(100, ErrorMessage = "Паролата трябва да е поне {2} символа.", MinimumLength = Common.GlobalConstants.PasswordMinLength)]
        [DataType(DataType.Password)]
        [Display(Name = "Нова парола")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потвърдете новата парола")]
        [Compare("NewPassword", ErrorMessage = "Паролата не съпада, моля опитайте отново!")]
        public string ConfirmPassword { get; set; }
    }
}
