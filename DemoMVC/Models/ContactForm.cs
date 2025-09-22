using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "Ce champs est requis")]
        [EmailAddress(ErrorMessage = "Email invalide")]
        public string Email { get; set; } = null!;

        [DataType(DataType.PhoneNumber)]
        [RegularExpression("^\\d{8,9}$", ErrorMessage = "Numero invalide")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Ce champs est requis")]
        public string Message { get; set; } = null!;
    }
}
