using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        /*
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
        */



        public void sendEmailToVarious(List<string> destinatarios, string asunto, string cuerpo, string nombreEvento)  //LA LISTA DE EMAILS ES SIEMPRE DEL EVENTO 61 PARA PROBAR EN LA CLASE User.cs REVISAR AL JUNTAR CON TODOS
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
            mensaje = nombreEvento + ":" + "<br/><br/><br/>" + mensaje + "<br/><br/><br/>" +  "<em>" + "Notificación enviada por el organizador del evento a través de la plataforma" + "</em>" + "<br/><br/>" + "<img src='cid:imagen' />";
            //mail.Body = mensaje;

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mensaje, Encoding.UTF8, MediaTypeNames.Text.Html);


            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + "asuma2correo1.png";
            LinkedResource img = new LinkedResource(imagePath, MediaTypeNames.Image.Jpeg);
            img.ContentId = "imagen";

            // Lo incrustamos en la vista HTML...

            htmlView.LinkedResources.Add(img);

            // Por último, vinculamos la vista al mensaje...

            mail.AlternateViews.Add(htmlView);

            // Y lo enviamos a través del servidor SMTP...
            smtp.Send(mail);
        }


        public void sendEmailToAdmin(string nombreRemitente, string remitente, string asunto, string cuerpo)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("noreply.asuma@gmail.com", "ASUMA");
            mail.To.Add(new MailAddress("lospumasdelauma@gmail.com"));  //ADMIN
            mail.Subject = asunto;
            mail.IsBodyHtml = true;
            string mensaje = cuerpo;
            mensaje = mensaje + "<br/><br/><br/>" + "<em>" + "Enviado a través del formulario de contacto<br/>Enviado por: " + nombreRemitente + "    (" + remitente + ")" + "</em>" + "<br/><br/>" + "<img src='cid:imagen' />";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mensaje, Encoding.UTF8,MediaTypeNames.Text.Html);


            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + "asuma2correo1.png";
            LinkedResource img = new LinkedResource(imagePath, MediaTypeNames.Image.Jpeg);
            img.ContentId = "imagen";

            // Lo incrustamos en la vista HTML...

            htmlView.LinkedResources.Add(img);

            // Por último, vinculamos la vista al mensaje...

            mail.AlternateViews.Add(htmlView);

            // Y lo enviamos a través del servidor SMTP...
            smtp.Send(mail);
        }

        public void sendEmailRecoverPassword(string destinatario, string token)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("noreply.asuma@gmail.com", "ASUMA");
            mail.To.Add(new MailAddress(destinatario)); 
            mail.Subject = "Recuperación de contraseña";
            mail.IsBodyHtml = true; 
            string mensaje = "Hemos recibido una petición de recuperación de contraseña" + "<br/><br/><br/>" + "Código de recuperación: " + "<em>" + token + "</em>";
            mensaje = mensaje + "<br/><br/><br/>" + "<em>" + "Mensaje generado automaticamente<br/>"+ "</em>" + "<br/><br/>" + "<img src='cid:imagen' />";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mensaje, Encoding.UTF8, MediaTypeNames.Text.Html);


            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + "asuma2correo1.png";
            LinkedResource img = new LinkedResource(imagePath, MediaTypeNames.Image.Jpeg);
            img.ContentId = "imagen";

            // Lo incrustamos en la vista HTML...

            htmlView.LinkedResources.Add(img);

            // Por último, vinculamos la vista al mensaje...

            mail.AlternateViews.Add(htmlView);

            // Y lo enviamos a través del servidor SMTP...
            smtp.Send(mail);
        }

        public void sendEmailToInscripted(string destinatario, Event evento)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("noreply.asuma@gmail.com", "ASUMA");
            mail.To.Add(new MailAddress(destinatario));
            mail.Subject = "Nueva inscripción";
            mail.IsBodyHtml = true;
            string mensaje = "Muchas gracias por realizar su inscripción al evento: " + evento.EventName + "<br/><br/>" + "Esperamos que disfrute y no dude en contactar con el creador del evento ante cualquier duda: " + evento.EventCreator;
            mensaje = mensaje + "<br/><br/><br/>" + "<em>" + "Mensaje generado automaticamente<br/>" + "</em>" + "<br/><br/>" + "<img src='cid:imagen' />";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mensaje, Encoding.UTF8, MediaTypeNames.Text.Html);


            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + "asuma2correo1.png";
            LinkedResource img = new LinkedResource(imagePath, MediaTypeNames.Image.Jpeg);
            img.ContentId = "imagen";

            // Lo incrustamos en la vista HTML...

            htmlView.LinkedResources.Add(img);

            // Por último, vinculamos la vista al mensaje...

            mail.AlternateViews.Add(htmlView);

            // Y lo enviamos a través del servidor SMTP...
            smtp.Send(mail);
        }

        public void sendEmailToCancelInscription(string destinatario, Event evento, User organizador)
        {
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("noreply.asuma@gmail.com", "ASUMA");
            mail.To.Add(new MailAddress(destinatario));
            mail.Subject = "Inscripción cancelada";
            mail.IsBodyHtml = true;
            string mensaje = "Ha sido eliminada su suscripción al evento \"" + evento.EventName + "\" por parte del organizador " + "<br/><br/>" + "Ante cualquier cuestión o réplica, no dude en contactar con el: " + organizador.Username + "<em>" + "(" + organizador.Email + ")" + "</emisor>"; 
            mensaje = mensaje + "<br/><br/><br/>" + "<em>" + "Mensaje generado automaticamente<br/>" + "</em>" + "<br/><br/>" + "<img src='cid:imagen' />";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mensaje, Encoding.UTF8, MediaTypeNames.Text.Html);


            string path = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string imagePath = pathBueno + "images\\" + "asuma2correo1.png";
            LinkedResource img = new LinkedResource(imagePath, MediaTypeNames.Image.Jpeg);
            img.ContentId = "imagen";

            // Lo incrustamos en la vista HTML...

            htmlView.LinkedResources.Add(img);

            // Por último, vinculamos la vista al mensaje...

            mail.AlternateViews.Add(htmlView);

            // Y lo enviamos a través del servidor SMTP...
            smtp.Send(mail);
        }

        public void sendEmailCertificate(string destinatario, Event evento, User organizador)
        {
            string path = Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath);
            string pathBueno = path.Substring(0, path.Length - 3);
            string documentPath = pathBueno + "documents\\" + "certificado.pdf";
            Attachment data = new Attachment(documentPath, MediaTypeNames.Application.Octet);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("noreply.asuma@gmail.com", "ASUMA");
            mail.To.Add(new MailAddress(destinatario));
            mail.Subject = "Certificado de curso";
            mail.IsBodyHtml = true;
            string mensaje = "Enhorabuena por haber completado el curso " + "<em>" + "\"" + evento.EventName + "\" " + "</em>" + " con éxito." + "<br/><br/>" + "Le adjuntamos su certificado válido que acredita que usted ha logrado aprobar el curso." + "<br/><br/>" + "Ante cualquier cuestión o réplica, no dude en contactar con el organizador: " + "<em>" + organizador.Username + "<em> " + "(" + organizador.Email + ")" + "</emisor>";
            mensaje = mensaje + "<br/><br/><br/>" + "<em>" + "Mensaje generado automaticamente<br/>" + "</em>" + "<br/><br/>" + "<img src='cid:imagen' />";

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(mensaje, Encoding.UTF8, MediaTypeNames.Text.Html);

            mail.Attachments.Add(data);
            string path2 = Path.GetDirectoryName(Application.StartupPath);
            string pathBueno2 = path2.Substring(0, path.Length - 3);
            string imagePath = pathBueno2 + "images\\" + "asuma2correo1.png";
            LinkedResource img = new LinkedResource(imagePath, MediaTypeNames.Image.Jpeg);
            img.ContentId = "imagen";

            // Lo incrustamos en la vista HTML...

            htmlView.LinkedResources.Add(img);

            // Por último, vinculamos la vista al mensaje...

            mail.AlternateViews.Add(htmlView);

            // Y lo enviamos a través del servidor SMTP...
            smtp.Send(mail);
        }


    }
}
