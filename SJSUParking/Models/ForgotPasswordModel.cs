﻿using System;
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

        [Required]
        [Display(Name = "SJSU Id")]
        public string SJSUId { get; set; }
  
    }
}