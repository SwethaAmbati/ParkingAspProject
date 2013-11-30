using SJSUParking.Models;
using SJSUParking.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SJSUParking.Controllers
{
    public class RegistrationController : Controller
    {
        //
        // GET: /Registration/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(UserModel user)
        {
            if (ModelState.IsValid)
            {
                DAL.CreateNewUser(user);
                return RedirectToAction("index", "Login");
            }
            return View();
        }

    }
}
