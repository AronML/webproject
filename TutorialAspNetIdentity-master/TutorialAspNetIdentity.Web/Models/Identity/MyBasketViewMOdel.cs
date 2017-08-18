using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TutorialAspNetIdentity.Web.Models.Identity
{
    public class AddressBasketViewModel
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo Endereço deve ser preenchido")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [RegularExpression(@"^\d{2}\.\d{3}-\d{3}$", ErrorMessage = "Informe um CEP válido, do tipo XX.XXX-XXX")]
        [Required(ErrorMessage = "O campo CEP deve ser preenchido")]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Cidade deve ser preenchido")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Estado deve ser preenchido")]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        
    }
}