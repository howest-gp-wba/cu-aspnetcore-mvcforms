using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.MvcForms.ViewModels
{
    public class InputsViewModel
    {
        [Display(Name="E-mail")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "URL")]
        [Url]
        public Uri Url { get; set; }

        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; }

        [Display(Name = "Your favorite integer")]
        public int FavoriteInt { get; set; }
        
        [Display(Name = "PI (math)")]
        [DisplayFormat(DataFormatString="{0:N4}", ApplyFormatInEditMode = true)]
        public double PI { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Date and time")]
        public DateTime EnteredDateAndTime { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date")]
        [DisplayFormat()]
        public DateTime EnteredDate { get; set; }

        [Display(Name = "Time")]
        [DataType(DataType.Time)]
        public DateTime EnteredTime { get; set; }

        [MaxLength(200)]
        [Display(Name = "Short Description")]
        public string ShortDescription { get; set; }

        [Display(Name = "Show summary")]
        public bool ShowSummary { get; set; }

        [HiddenInput]
        [Display(Name = "Resolution")]
        public string ScreenResolution { get; set; }
    }
}
