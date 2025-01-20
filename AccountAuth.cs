using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace defaultwinform
{
    internal class AccountAuth
    {
        public static void sendRegistrationEmail()
        {

            string smtpServer = "smtp.gmail.com"; 
            int smtpPort = 587; 
            string senderEmail = "geomindapplication@gmail.com";
            string senderPassword = "kmro jfnh wmma gwzi";

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderEmail);
            mail.To.Add(Program.currentAccount.getEmail());
            mail.Subject = "Welcome to GeoMind!";
            mail.Body = createBody();

            SmtpClient smtpClient = new SmtpClient(smtpServer, smtpPort);
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);
            smtpClient.EnableSsl = true;

            smtpClient.Send(mail);
        }

        public static String createBody()
        {
            String body = "Welcome to GeoMind " + Program.currentAccount.getName();

            return body;
        }
    }
}
