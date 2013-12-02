using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Security;
using SJSUParking.Models;


namespace SJSUParking.Controllers
{
    public class ForgotPasswordModel
    {
        [Required]
        [Display(Name = "Email Address")]
        public string email { get; set; }

        public void RequestPassword(string email)
        {
            MembershipUser currentUser = Membership.GetUser(email);
            string password = currentUser.ResetPassword();
            SendEmail.SendResetEmail(currentUser);
        }

      
    }
}