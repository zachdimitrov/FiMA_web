namespace Fima.Web.ViewModels.Manage
{
    using System.ComponentModel.DataAnnotations;

    public class AddPhoneNumberViewModel
    {
        [Required(ErrorMessage = "Моля, въведете телефонен номер!")]
        [Phone]
        [Display(Name = "Телефонен номер")]
        public string Number { get; set; }
    }
}
