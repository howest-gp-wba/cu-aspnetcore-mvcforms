using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.MvcForms.ViewModels
{
    public class ValidatedFormViewModel
    {
        [Required]
        [Display]
        public string Username { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Range(1000, 9999)]
        public int Code { get; set; }
        
    }
}
