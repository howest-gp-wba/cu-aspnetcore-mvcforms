using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CoreCourse.MvcForms.ViewModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace CoreCourse.MvcForms.Controllers
{
    public enum ProgrammingLanguages
    {
        [Display(Name = "C#")]
        CSharp = 1,
        Javascript = 2,
        Python = 3,
        [Display(Name = "C++")]
        CPlusPlus = 4,
        [Display(Name = "Other language")]
        OtherLanguage = 5
    }


    public class SelectListsController : Controller
    {
        public IActionResult Index()
        {
            var optionGroups = new List<SelectListGroup>
            {
                new SelectListGroup{ Name = "Europe" },
                new SelectListGroup{ Name = "North America" }
            };

            var selectListsViewModel = new SelectListsViewModel();
            selectListsViewModel.SimpleSelect = new SimpleSelectVm
            {
                SelectedCountryId = 1,
                Countries = new List<SelectListItem> {
                    new SelectListItem { Value = "0", Text = "== Pick a Country ==" },
                    new SelectListItem { Value = "1", Text = "Belgium" },
                    new SelectListItem { Value = "2", Text = "Netherlands" },
                    new SelectListItem { Value = "3", Text = "Luxemburg" }
                }
            };


            selectListsViewModel.GroupedSelect = new SimpleSelectVm
            {
                SelectedCountryId = 1,
                Countries = new List<SelectListItem> {
                    new SelectListItem { Value = "0", Text = "== Pick a Country ==" },
                    new SelectListItem { Value = "1", Text = "Belgium", Group = optionGroups[0] },
                    new SelectListItem { Value = "2", Text = "Netherlands", Group = optionGroups[0] },
                    new SelectListItem { Value = "3", Text = "Luxemburg", Group = optionGroups[0] },
                    new SelectListItem { Value = "4", Text = "USA", Group = optionGroups[1] },
                    new SelectListItem { Value = "5", Text = "Canada", Group = optionGroups[1] },
                }
            };

            selectListsViewModel.MultipleSelect = new MultipleSelectVm
            {
                SelectedCountryIds = new List<int> { 1, 3 },
                Countries = new List<SelectListItem>
                {
                    new SelectListItem {
                        Value = "1",
                        Text = "Belgium"
                    },
                    new SelectListItem {
                        Value = "2",
                        Text = "Netherlands"
                    },
                    new SelectListItem {
                        Value = "3",
                        Text = "Luxemburg"
                    }
                }
            };

            return View(selectListsViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ShowPicks(SelectListsViewModel selectListsViewModel)
        {
            if (selectListsViewModel.SimpleSelect != null)
            {
                return Content($"You selected country with ID {selectListsViewModel.SimpleSelect.SelectedCountryId}");
            }
            else if (selectListsViewModel.GroupedSelect != null)
            {
                return Content($"You selected country with ID {selectListsViewModel.GroupedSelect.SelectedCountryId}");
            }
            else if (selectListsViewModel.MultipleSelect != null)
            {
                int numberIds = selectListsViewModel.MultipleSelect.SelectedCountryIds.Count();
                string idsString = selectListsViewModel.MultipleSelect.SelectedCountryIds.Select(i => i.ToString()).Aggregate((s, t) => s + ", " + t);
                return Content($"You selected {numberIds} countries with IDs {idsString}");
            }
            else 
            {
                return Content($"You selected {selectListsViewModel.FavoriteLanguage} as your favorite language.");
            }
        }
    }
}
