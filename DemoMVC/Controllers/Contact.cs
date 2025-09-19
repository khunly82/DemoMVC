using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace DemoMVC.Controllers
{
    public class Contact : Controller
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

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "sandbox.smtp.mailtrap.io";
            smtp.Port = 25;
            smtp.Credentials = new NetworkCredential("ebb3e8a64c2994", "60530c32436ff2");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

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
