using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Entities
{
    public class Order
    {
        [Key]
        public string Reference { get; set; } = null!;
        public DateTime CreationDate { get; set; }
        public DateTime? PaymentDate { get; set; }

        [ForeignKey("Customer")]
        public string CustomerRef { get; set; } = null!;
        public decimal TotalPrice { get; set; }
        public Status OrderStatus { get; set; }

        public Customer Customer { get; set; } = null!;

        public List<OrderLine> OrderLines { get; set; } = null!;

        public enum Status
        {
            InProgress,
            Pending,
            Payed,
            Canceled
        }
    }
}
