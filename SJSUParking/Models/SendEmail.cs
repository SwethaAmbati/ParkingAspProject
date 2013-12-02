using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Security;
using System.Net.Mail;

namespace SJSUParking.Models
{
    public class SendEmail
    {
        public static void SendResetEmail(System.Web.Security.MembershipUser user)
        {
            MailMessage email = new MailMessage();

            email.From = new MailAddress("noreply@example.com");
            email.To.Add(new MailAddress(user.Email));

            email.Subject = "Password Request";
            email.IsBodyHtml = true;
            string Password = <%Password%>;
            
            email.Body = "<p>Your Password is" + Password + "</p>"; 
              

            SmtpClient smtpClient = new SmtpClient();

            smtpClient.Send(email);
        }
    }
}