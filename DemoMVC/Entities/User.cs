using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public Role UserRole { get; set; }

        public enum Role
        {
            Admin, Seller, Restocker
        }
    }
}
