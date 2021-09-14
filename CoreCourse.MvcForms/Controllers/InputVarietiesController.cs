using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreCourse.MvcForms.ViewModels;

namespace CoreCourse.MvcForms.Controllers
{
    public class InputVarietiesController : Controller
    {
        public IActionResult Index()
        {
            InputsViewModel model = new InputsViewModel();
            model.PI = Math.PI;
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(InputsViewModel userData)
        {
            if (userData.ShowSummary)
            {
                //display the summary View with posted data
                return View("InputSummary", userData);
            }
            //re-display form, with pre-filled values
            return View(userData);
        }
    }
}
