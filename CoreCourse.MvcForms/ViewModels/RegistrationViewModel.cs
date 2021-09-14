using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.MvcForms.ViewModels
{
    public class RegistrationViewModel
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Please provide a username")]
        [StringLength(200, MinimumLength = 5,
                      ErrorMessage = "Username must be between {2} and {1} characters")]
        [RegularExpression(@"^[\w\d.]{5,}$",
                      ErrorMessage = "Username cannot contain whitespaces or special characters")]
        public string UserName { get; set; }

        [Display(Name = "E-mail address")]
        [Required]
        [EmailAddress(ErrorMessage = "Please provide a valid e-mail adress")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(8, ErrorMessage = "Your password should contain atleast {1} characters")]
        public string Password { get; set; }

        [Display(Name = "Repeat password")]
        [DataType(DataType.Password)]
        [Compare(nameof(Password), ErrorMessage = "The passwords you have provided do not match")]
        public string RepeatPassword { get; set; }

        [Display(Name = "Date of birth")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Creditcard number")]
        [CreditCard(ErrorMessage = "Please enter a valid credit card number")]
        public string CreditCardNumber { get; set; }

        [Display(Name = "Phone number")]
        [Phone(ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Favorite website")]
        [Url(ErrorMessage = "Please enter a valid URL")]
        public string FavoriteSite { get; set; }

        [Display(Name = "I have read and agree to the license terms")]
        public bool AgreeToLicense { get; set; }
    }
}
