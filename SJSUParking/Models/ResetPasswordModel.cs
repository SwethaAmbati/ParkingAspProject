using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Security;
using SJSUParking.Models;

namespace SJSUParking.Models
{
    public class ResetPasswordModel
    {
        [Required]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "SJSU Id")]
        public string SJSUId { get; set; }
    }
}