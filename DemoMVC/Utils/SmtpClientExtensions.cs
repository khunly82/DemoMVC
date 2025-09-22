using DemoMVC.Models;
using System.Net.Mail;

namespace DemoMVC.Utils
{
    public static class SmtpClientExtensions
    {
        public static void SendMessage(
            // permet de rajouter la methode sendMessage à la classe SmtpClient
            this SmtpClient client,
            string dest, 
            string subject, 
            string message
        )
        {
            MailMessage mailmessage = new()
            {
                From = new MailAddress("no-reply@mysite.com")
            };

            mailmessage.To.Add(new MailAddress(dest));

            mailmessage.Subject = subject;

            mailmessage.IsBodyHtml = true;

            mailmessage.Body = message;
        }
    }
}
