using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SJSUParking.Models
{
    public class ReservedParkingModel
    {
        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date, ErrorMessage = "Please enter a valid date in the format mm/dd/yyyy")]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Date, ErrorMessage = "Please enter a valid date in the format mm/dd/yyyy")]
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Time, ErrorMessage = "Please enter a valid time in the format HH:mm:ss")]
        [Display(Name = "Start Time")]
        public string StartTime { get; set; }
        [Required]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Time, ErrorMessage = "Please enter a valid time in the format HH:mm:ss")]
        [Display(Name = "End Time")]
        public string EndTime { get; set; }

        public string ParkingSlotId { get; set; }
        public float Duration { get; set; }
    }
}