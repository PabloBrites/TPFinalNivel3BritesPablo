using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace negocio//
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;

        public EmailService()
        {
            server = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(
                    "pabloalejandrobrites@gmail.com",
                    "eihqnyiirzrgccqj"
                )
            };
        }

        public void ArmarCorreo(string emailDestino, string asunto, string cuerpo)
        {
            email = new MailMessage
            {
                From = new MailAddress("pabloalejandrobrites@gmail.com"),
                Subject = asunto,
                Body = cuerpo,
                IsBodyHtml = false
            };

            email.To.Add(emailDestino);
        }

        public void EnviarEmail()
        {
            server.Send(email);
        }
    }
}
