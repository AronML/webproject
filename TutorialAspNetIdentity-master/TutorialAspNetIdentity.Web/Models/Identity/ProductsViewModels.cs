using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TutorialAspNetIdentity.Web.Models.Identity
{
    public class InsertProductsViewModels
    {
        [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
        [Display(Name = "Nome")]
        public string name { get; set; }

        [Required(ErrorMessage = "O campo Informações deve ser preenchido")]
        [Display(Name = "Informações")]
        public string info { get; set; }

        [Required(ErrorMessage = "O campo Valor deve ser preenchido")]
        [Display(Name = "Valor")]
        public int value { get; set; }


    }
    public class UpdateProductsViewModels
    {
        [Required(ErrorMessage = "O campo Nome deve ser preenchido")]
        [Display(Name = "Nome")]
        public string name { get; set; }

        [Required(ErrorMessage = "O campo Informações deve ser preenchido")]
        [Display(Name = "Informações")]
        public string info { get; set; }

        [Required(ErrorMessage = "O campo Valor deve ser preenchido")]
        [Display(Name = "Valor")]
        public int value { get; set; }


    }
    public class DeleteProductsViewModels
    {

    }
   
}