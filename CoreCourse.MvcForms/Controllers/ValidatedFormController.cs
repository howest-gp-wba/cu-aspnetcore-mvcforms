using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreCourse.MvcForms.ViewModels;

namespace CoreCourse.MvcForms.Controllers
{
    public class ValidatedFormController : Controller
    {
        private string[] bannedIps = new string[] { "127.0.0.1", "::1" };

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(ValidatedFormViewModel validatedFormViewModel)
        {
            //check if users' ip is banned
            string remoteIp = HttpContext.Connection.RemoteIpAddress.ToString();
            if (bannedIps.Contains(remoteIp))
            {
                ModelState.AddModelError(string.Empty,
                    $"Your IP {remoteIp} has been temporarily banned. Please try again later.");
            }
            
            if (ModelState.IsValid) 
            {
                return new RedirectToActionResult("CodeSuccess", "ValidatedForm", null);
            }
            else
            {
                return View(validatedFormViewModel);
            }
        }

        public IActionResult CodeSuccess()
        {
            return View();
        }
    }
}
