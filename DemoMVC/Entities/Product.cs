using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Entities
{
    public class Product
    {
        [Key]
        public string Reference { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public decimal LastBuyingPrice { get; set; }
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }

        // propriétés de navigation
        public List<OrderLine> OrderLines { get; set; } = null!;
    }
}
