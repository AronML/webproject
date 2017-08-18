using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TutorialAspNetIdentity.Web.Models.Identity
{
   
    public class AddPlaceViewModel
    {
        [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        
    }
    public class UpdatePlaceViewModel
    {
        [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
        [Display(Name = "Nome")]
        public string Name { get; set; }


    }
    public class DeletePlaceViewModel
    {
        [Required]
        [Display(Name = " Nome")]
        public string Name { get; set; }
    }
}