using SJSUParking.Models.DataAccess;
using System;
using System.Web;
using System.Collections.Generic;
using System.Linq;
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

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(ForgotPasswordModel forgotpasswordmodel)
        {
            if (ModelState.IsValid)
            {
                
                if (DAL.ValidSjsuIdAndEmail(forgotpasswordmodel.SJSUId, forgotpasswordmodel.email))
                {
                    //FormsAuthentication.SetAuthCookie(forgotpasswordmodel.SJSUId, false);
                    return RedirectToAction("index", "ResetPassword");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Email Address or Sjsu Id");
                }

            }
            return View();
        }
    }
}
