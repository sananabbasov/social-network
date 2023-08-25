using System;
using K401SocialApp.Core.Configurations;
using System.Net;
using System.Net.Mail;

namespace K401SocialApp.Core.Utilities.EmailHelper
{
    public class EmailSender : IEmailSender
    {
        public bool SendMail(string mailAddress, string message, bool bodyHtml)
        {

            var emailAddress = EmailConfiguration.Email;
            var emailPassword = EmailConfiguration.Password;
            string senderEmail = emailAddress;
            string senderPassword = emailPassword;

            //Create the SMTP client
            SmtpClient smtpClient = new SmtpClient(EmailConfiguration.Smtp, EmailConfiguration.Port);
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential(senderEmail, senderPassword);

            try
            {
                // Create the email message
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(senderEmail);
                mailMessage.To.Add(mailAddress);
                mailMessage.Subject = $"Message from - {EmailConfiguration.Email}";
                mailMessage.Body = $"<a href='https://localhost:7147/api/auth/verifypassword?email={mailAddress}&token={message}'>Tesdiq et</a>";
                // Specify that the body contains HTML
                mailMessage.IsBodyHtml = true;
                // Send the email
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email sent successfully.");
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending email: " + ex.Message);
                return false;

            }
        }
    }
}

