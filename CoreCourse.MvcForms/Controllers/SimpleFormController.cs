using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreCourse.MvcForms.ViewModels;

namespace CoreCourse.MvcForms.Controllers
{
    public class SimpleFormController : Controller
    {
        public IActionResult Index()
        {
            var simpleFormViewModel = new SimpleFormViewModel();
            simpleFormViewModel.RememberMe = true;
            return View(simpleFormViewModel);
        }

        [HttpGet]
        public IActionResult SubmitWithGet(SimpleFormViewModel simpleFormViewModel)
        {
            var SimpleFormSubmitViewModel = new SimpleFormSubmitViewModel
            {
                Data = simpleFormViewModel,
                Method = "GET"
            };
            return View("Submit", SimpleFormSubmitViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitWithPost(SimpleFormViewModel simpleFormViewModel)
        {
            var simpleFormSubmitViewModel = new SimpleFormSubmitViewModel
            {
                Data = simpleFormViewModel,
                Method = "POST"
            };
            return View("Submit", simpleFormSubmitViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitWithRoute(SimpleFormViewModel simpleFormViewModel)
        {
            var simpleFormSubmitViewModel = new SimpleFormSubmitViewModel
            {
                Data = simpleFormViewModel,
                Method = "Route/Post"
            };
            return View("Submit", simpleFormSubmitViewModel);
        }
    }
}
