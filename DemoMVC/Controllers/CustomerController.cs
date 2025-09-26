
using DemoMVC.Entities;
using DemoMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace DemoMVC.Controllers
{
    public class CustomerController(StockContext _db) : Controller
    {
        [HttpGet]
        [Authorize] // je dois etre connecter peut importe le role
        public IActionResult Index([FromQuery]string? search)
        {
            ViewBag.Search = search; 

            IQueryable<Customer> query = _db.Customers
                // dans le cas ou on utilise un mapper, il faut ajouter le jointure de manière explicite
                .Include(c => c.Orders)
                .Where(c => !c.IsDeleted);

            if(search != null)
            {
                query = query.Where(c => c.LastName.StartsWith(search) || c.FirstName.StartsWith(search));
            }

            var customers = query.Select(c => new CustomerIndexViewModel(c))
                .ToList();

            return View(customers);
        }

        [HttpGet]
        [Authorize(Roles = "admin")] // je dois etre admin
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "admin")] // je dois etre admin
        public IActionResult Create(CustomerForm form)
        {
            // valider les données
            if(ModelState.IsValid)
            {
                if(_db.Customers.Any(c => c.Email == form.Email))
                {
                    // ajouter une erreur globale
                    // TempData["error"] = "Email Invalide";
                    // ajouter une erreur directement sur l'email
                    ModelState.AddModelError("Email", "Email déjà utilisé");
                    return View();
                }

                string reference = form.Nom[..2] + form.Prenom[..2];

                int count = _db.Customers.Count(c => c.Reference.StartsWith(reference)) + 1;

                reference = reference.ToUpper() + count.ToString().PadLeft(4, '0');

                _db.Customers.Add(new Customer
                {
                    // mapping
                    LastName = form.Nom,
                    FirstName = form.Prenom,
                    Email = form.Email,
                    Phone = form.Tel,
                    Reference = reference
                });

                _db.SaveChanges();
                return RedirectToAction("Index");

            }
            TempData["error"] = "Formulaire Invalide";
            return View();
        }


        [HttpGet]
        [Authorize(Roles = "admin")] // je dois etre admin
        public IActionResult Delete(string id)
        {
            Customer? c = _db.Customers.Find(id);
            if(c == null)
            {
                return NotFound();
            }

            // retirer de la db
            // _db.Customers.Remove(c);

            c.IsDeleted = true;

            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize(Roles = "admin,seller")] // je dois etre admin ou vendeur
        public IActionResult Edit(string id)
        {
            Customer? customer = _db.Customers.Find(id);
            
            if(customer == null)
            {
                return NotFound();
            }

            return View(new CustomerForm
            {
                Email = customer.Email,
                Nom = customer.LastName,
                Prenom = customer.FirstName,
                Tel = customer.Phone
            });
        }

        [HttpPost]
        [Authorize(Roles = "admin,seller")]
        public IActionResult Edit(string id, CustomerForm form)
        {
            Customer? customer = _db.Customers.Find(id);
            if (customer == null) 
            {
                return NotFound();
            }

            if(ModelState.IsValid)
            {
                if(_db.Customers.Any(c => c.Email == form.Email && c.Reference != id))
                {
                    ModelState.AddModelError("Email", "Cet email est déjà utilisé par un autre client");
                    return View();
                }
                customer.Email = form.Email;
                customer.LastName = form.Nom;
                customer.FirstName = form.Prenom;
                customer.Phone = form.Tel;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            TempData["error"] = "Formulaire Invalide";
            return View();
        }
    }
}
