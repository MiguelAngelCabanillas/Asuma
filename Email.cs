using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Asuma
{
   public class Email
    {
        private SmtpClient smtp;
        private string emisor = "noreply.asuma@gmail.com";
        private string password = "pumasasuma";
        public Email()
        {
                
            smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.EnableSsl = true;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(emisor, password);
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
    }

        public void sendEmailToAdmin(string nombreRemitente, string remitente, string asunto, string cuerpo)
        {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("noreply.asuma@gmail.com", "ASUMA");
                mail.To.Add(new MailAddress("lospumasdelauma@gmail.com"));  //ADMIN
                mail.Subject = asunto;
                mail.IsBodyHtml = true;
                string mensaje = cuerpo;
                mensaje = mensaje + "<br/><br/><br/>" + "ENVIADO A TRAVES DEL FORMULARIO DE CONTACTO<br/>ENVIADO POR: " + nombreRemitente + "    (" + remitente + ")";
                mail.Body = mensaje;

                smtp.Send(mail);
        }

        public void sendEmailTo(List<string> destinatarios, string asunto, string cuerpo, string nombreEvento)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("noreply.asuma@gmail.com", "ASUMA");
            foreach (string d in destinatarios)
            {
                mail.To.Add(new MailAddress(d));
            }
            mail.Subject = asunto;
            mail.IsBodyHtml = true;
            string mensaje = cuerpo;
            mensaje = nombreEvento + ":" + "<br/><br/><br/>" + mensaje + "<br/><br/><br/>" + "Notificación enviada a través de la plataforma";
            mail.Body = mensaje;

            smtp.Send(mail);
        }
    }
}
