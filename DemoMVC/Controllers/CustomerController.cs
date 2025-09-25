
using DemoMVC.Entities;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DemoMVC.Controllers
{
    public class CustomerController(StockContext _db) : Controller
    {
        public IActionResult Index([FromQuery]string? search)
        {
            ViewBag.Search = search; 

            IQueryable<Customer> query = _db.Customers
                // dans le cas ou on utilise un mapper, il faut ajouter le jointure de manière explicite
                .Include(c => c.Orders);

            if(search != null)
            {
                query = query.Where(c => c.LastName.StartsWith(search) || c.FirstName.StartsWith(search));
            }

            var customers = query.Select(c => new CustomerIndexViewModel(c))
                .ToList();

            return View(customers);
        }
    }
}
