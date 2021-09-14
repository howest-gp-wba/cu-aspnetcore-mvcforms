using CoreCourse.MvcForms.Controllers;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCourse.MvcForms.ViewModels
{
    public class SelectListsViewModel
    {
        public SimpleSelectVm SimpleSelect { get; set; }
        public SimpleSelectVm GroupedSelect { get; set; }
        public MultipleSelectVm MultipleSelect { get; set; }

        [Display(Name ="Favorite Programming lanugage")]
        public ProgrammingLanguages FavoriteLanguage { get; set; }
    }

    public class SimpleSelectVm
    {
        [Display(Name = "Pick a country")]
        public int SelectedCountryId { get; set; }
        public List<SelectListItem> Countries { get; set; }
    }


    public class MultipleSelectVm
    {
        [Display(Name = "Pick some countries")]
        public IEnumerable<int> SelectedCountryIds { get; set; }
        public IEnumerable<SelectListItem> Countries { get; set; }
    }
}
