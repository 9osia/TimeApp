using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TimeApp.ViewModels
{
    public class CreateItemViewModel
    {
        [Required]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Display(Name = "Opis")]
        public string Description { get; set; }

        [Display(Name = "Priorytet")]
        [Range(0,5)]
        public int Priority { get; set; }

        [Display(Name = "Projekt")]
        public int ProjectId { get; set; }

        public IEnumerable<SelectListItem>  Projects { get; set; }
    }
}