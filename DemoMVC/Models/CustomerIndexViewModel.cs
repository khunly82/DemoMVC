using DemoMVC.Entities;

namespace DemoMVC.Models
{
    public class CustomerIndexViewModel(Customer customer)
    {
        public string Ref { get; set; } = customer.Reference;
        public string LastName { get; set; } = customer.LastName;
        public string FirstName { get; set; } = customer.FirstName;
        public int NbOrders { get; set; } = customer.Orders.Count;
    }
}
