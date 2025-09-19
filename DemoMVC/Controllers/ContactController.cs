using System.Net;
using System.Net.Mail;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMail(ContactFormModel model )
        {

            var client = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("b2c30afa384761", "3b7808f937d0cc"),
                EnableSsl = true
            };
            client.Send(model.Email, "wendie.mazy@gmail.com", "Message envoyer depuis un formulaire ***** **** ********", model.Msg);
            System.Console.WriteLine("Sent");
            return View("Index");
        }
    }
}
