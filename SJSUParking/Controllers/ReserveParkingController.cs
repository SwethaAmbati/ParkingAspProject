﻿using SJSUParking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SJSUParking.Controllers
{
    public class ReserveParkingController : Controller
    {
        //
        // GET: /ReserveParking/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(ReservedParkingModel reservedParkingModel)
        {
            if (ModelState.IsValid)
            {
            }
            return View();
        }

    }
}
