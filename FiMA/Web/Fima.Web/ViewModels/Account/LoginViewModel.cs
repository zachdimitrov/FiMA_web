namespace Fima.Web.ViewModels.Account
{
    using System.ComponentModel.DataAnnotations;

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Потребителското име е задължително!")]
        [Display(Name = "Потребител")]
        [StringLength(50, ErrorMessage = "Потребителското име трябва да е поне {2} символа.", MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Паролата е задължителна!")]
        [DataType(DataType.Password)]
        [Display(Name = "Парола")]
        public string Password { get; set; }

        [Display(Name = "Запомни ме?")]
        public bool RememberMe { get; set; }
    }
}
