using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SJSUParking.Models;
using SJSUParking.Models.DataAccess;


namespace SJSUParking.Controllers
{
    public class ResetPasswordController : Controller
    {
        //
        // GET: /ResetPassword/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ResetPasswordModel Password)
        {
            if (ModelState.IsValid)
            {
                DAL.Reset(Password);
                return RedirectToAction("index", "Login");
            }
            return View();
        }
    }
}
