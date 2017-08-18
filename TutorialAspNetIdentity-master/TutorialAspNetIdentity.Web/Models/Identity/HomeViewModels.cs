using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TutorialAspNetIdentity.Web.Models.Identity
{
    public class ContactViewModels
    {
        [Required(ErrorMessage = "O campo Email deve ser preenchido")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Cidade deve ser preenchido")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Estado deve ser preenchido")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "O campo Mensagem deve ser preenchido")]
        [Display(Name = "Mensagem")]
        public string Mensagem { get; set; }

        
    }
}