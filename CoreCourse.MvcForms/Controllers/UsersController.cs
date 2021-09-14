using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreCourse.MvcForms.ViewModels;

namespace CoreCourse.MvcForms.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]        
        public IActionResult Register(RegistrationViewModel registrationModel)
        {
            if (ModelState.IsValid)
            {
                return new RedirectToActionResult("RegistrationSuccess", "Users", null);
            }
            else
            {
                return View(registrationModel);
            }
        }

        public IActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}
