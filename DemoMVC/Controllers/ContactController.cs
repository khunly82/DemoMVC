using DemoMVC.Models;
using DemoMVC.Utils;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Net.Mail;

namespace DemoMVC.Controllers
{
    public class ContactController(SmtpClient client) : Controller
    {
        // afficher le formulaire de contact
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // gérer l'envoi d'email
        [HttpPost]
        public IActionResult Index(ContactForm contactForm)
        {
            if (ModelState.IsValid)
            {
                // essayer envoyer un email
                try
                { 

                    client.SendMessage(
                        "lykhun@gmail.com",
                        "Vous avez recu un message",
                        $"<p>From : <a href='mailto:{contactForm.Email}'>{contactForm.Email}</a> ({contactForm.Phone})</p>" +
                        $"<p>{contactForm.Message}</p>"
                    );

                    // notification
                    TempData["success"] = "Message envoyé avec success";
                    return RedirectToAction("Index", "Home");

                }
                catch(SmtpException ex) 
                {
                    // notification
                    TempData["error"] = "Impossible d'envoyer votre email";
                    return View();
                }
            }
            // notification
            TempData["error"] = "Données formulaire non valide";
            return View();
        }
    }
}
