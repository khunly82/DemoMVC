using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class LoginForm
    {
        [Required]
        public string Username { get; set; } = null!;

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
