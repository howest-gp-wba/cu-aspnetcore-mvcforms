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
            var model = new SimpleFormViewModel();
            model.RememberMe = true;
            return View(model);
        }

        [HttpGet]
        public IActionResult SubmitWithGet(SimpleFormViewModel model)
        {
            var submitVm = new SimpleFormSubmitViewModel
            {
                Data = model,
                Method = "GET"
            };
            return View("Submit", submitVm);
        }

        [HttpPost]
        public IActionResult SubmitWithPost(SimpleFormViewModel model)
        {
            var submitVm = new SimpleFormSubmitViewModel
            {
                Data = model,
                Method = "POST"
            };
            return View("Submit", submitVm);
        }

        [HttpPost]
        public IActionResult SubmitWithRoute(SimpleFormViewModel model)
        {
            var submitVm = new SimpleFormSubmitViewModel
            {
                Data = model,
                Method = "Route/Post"
            };
            return View("Submit", submitVm);
        }
    }
}
