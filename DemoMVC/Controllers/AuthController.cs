using DemoMVC.Entities;
using DemoMVC.Models;
using DemoMVC.Utils;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DemoMVC.Controllers
{
    public class AuthController(StockContext _db) : Controller
    {
        [Route("login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(LoginForm form) 
        {
            // faire les verifs
            User? user = _db.Users.FirstOrDefault(u => u.Username == form.Username);
            if(user != null && PasswordUtils.Verify(form.Password, user.Password))
            {
                // authentifier l'utilisateur comme admin
                HttpContext.SignInAsync(new ClaimsPrincipal(new ClaimsIdentity([
                    new Claim(ClaimTypes.Name, user.Username),
                    new Claim(ClaimTypes.Role, user.UserRole.ToString().ToLower())
                ], "cookie")));
                return RedirectToAction("Index", "Home");
            }

            TempData["error"] = "Invalid Credentials";
            return View();

        }



        [Route("logout")]
        public IActionResult Logout() 
        {
            HttpContext.SignOutAsync();
            return RedirectToAction("login");
        }
    }
}
