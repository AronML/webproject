using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TutorialAspNetIdentity.Web.Models.Identity
{
    public class InsertObjViewModel
    {
        [Required(ErrorMessage = "O campo 'Nome quando ativado' deve ser preenchido")]
        [Display(Name = "Nome quando ativado")]
        public string NameActived { get; set; }

        [Required(ErrorMessage = "O campo 'Nome quando desativado' deve ser preenchido")]
        [Display(Name = "Nome quando desativado")]
        public string NameDesatived { get; set; }
    }
    
    public class UpdateObjViewModel
    {
        [Required(ErrorMessage = "O campo 'Nome quando ativado' deve ser preenchido")]
        [Display(Name = "Nome quando ativado")]
        public string NameActived { get; set; }

       [Required(ErrorMessage = "O campo 'Nome quando desativado' deve ser preenchido")]
        [Display(Name = "Nome quando desativado")]
        public string NameDesatived { get; set; }

    }
    public class DeleteObjViewModel
    {
        [Required]
        [Display(Name = "Nome quando ativado")]
        public string NameActived { get; set; }

        [Required]
        [Display(Name = "Nome quando destivado")]
        public string NameDesatived { get; set; }

    }
    
}