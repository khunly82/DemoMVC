using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace DemoMVC.Controllers
{
    public class Contact(SmtpClient smtp) : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public IActionResult SendEmail(RegisterViewModel model)
        {
            MailAddress from = new MailAddress(model.Email);
            MailAddress to = new MailAddress("ben@contoso.com");
            MailMessage message = new MailMessage(from, to);
            message.Subject = "formularie site";
            message.Body = model.Message;


            try
            {
                smtp.Send(message);
                TempData["success"] = "Email envoyé";
                return RedirectToAction("Index", "Home");
            }
            catch (SmtpException)
            {
                TempData["error"] = "L'email n'a pas pu etre envoyé";
                return RedirectToAction("Index", "Contact");
            }

        }
    }
}
