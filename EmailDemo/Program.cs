using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace EmailDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.bizmail.yahoo.com");

                mail.From = new MailAddress("marketing@progenbiologics.com");
                mail.To.Add("umesh.kumar99@gmail.com");
                mail.Subject = "Test message Report";
                mail.Body = "Report";
               // Attachment attachment = new Attachment(filename);
               // mail.Attachments.Add(attachment);

                SmtpServer.Port =587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("marketing@progenbiologics.com", "Hari@082017");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch(Exception ex)
            {

                throw ex;
            }
        }
    }
}
