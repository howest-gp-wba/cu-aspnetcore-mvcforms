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
            InputsViewModel inputsViewModel = new InputsViewModel();
            inputsViewModel.PI = Math.PI;
            return View(inputsViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(InputsViewModel inputsViewModel)
        {
            if (inputsViewModel.ShowSummary)
            {
                //display the summary View with posted data
                return View("InputSummary", inputsViewModel);
            }
            //re-display form, with pre-filled values
            return View(inputsViewModel);
        }
    }
}
