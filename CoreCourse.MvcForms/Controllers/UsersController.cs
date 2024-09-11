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
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegistrationViewModel registrationViewModel)
        {
            if (ModelState.IsValid)
            {
                return new RedirectToActionResult("RegistrationSuccess", "Users", null);
            }
            else
            {
                return View(registrationViewModel);
            }
        }

        public IActionResult RegistrationSuccess()
        {
            return View();
        }
    }
}
