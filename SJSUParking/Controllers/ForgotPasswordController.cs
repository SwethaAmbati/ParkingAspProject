using SJSUParking.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Diagnostics;
using SJSUParking.Models;

namespace SJSUParking.Controllers
{
    public class ForgotPasswordController : Controller
    {
        //
        // GET: /ForgotPassword/

       // public ActionResult Index()
        //{
          //  return View();
        //}

        public ActionResult index(string email)
        {
            if (email != null)
            {
                MembershipUser currentUser = Membership.GetUser(email);
                
                    ViewBag.newPass = currentUser.ResetPassword();
                    ViewBag.Email = email;
                    return View("Login");
                
            }

            return View();
        }
       


    }
}
