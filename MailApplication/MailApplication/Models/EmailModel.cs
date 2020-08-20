using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;


namespace MailApplication.Models
{
    public class EmailModel
    {
        public string To { get; set; }
        public string Subject { get; set; }
        public string BodyText { get; set; }

        public string SendMail(EmailModel model)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("melex01@gmail.com");
                mail.To.Add(model.To);
                mail.Subject = model.Subject;
                mail.Body = model.BodyText;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("melex01@gmail.com", "Password@123");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return "Mail sent successfully!";
            }
            catch (Exception)
            {
                return "Mail sent error!";
            }

        }
    }
}