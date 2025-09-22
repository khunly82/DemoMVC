using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Entities
{
    [Index("Email", IsUnique = true)]
    public class Customer
    {
        [Key]
        public string Reference { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Phone { get; set; }
        public bool IsDeleted { get; set; }

        public List<Order> Orders { get; set; } = null!;
    }
}
