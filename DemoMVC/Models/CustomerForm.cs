using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class CustomerForm
    {
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nom { get; set; } = null!;

        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Prenom { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;


        [DisplayName("Téléphone")]
        public string? Tel { get; set; }
    }
}
