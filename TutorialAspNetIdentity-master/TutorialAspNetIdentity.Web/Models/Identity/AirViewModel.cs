using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;


namespace TutorialAspNetIdentity.Web.Models.Identity
{
    public class AddAirViewModel
    {
        [Required(ErrorMessage = "O campo 'Nome' deve ser preenchido")]
        [Display(Name = "Nome")]
        public string Name { get; set; }

     
    }
}