using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TutorialAspNetIdentity.Web.Models.Identity
{
    public class UserRegisterViewModels
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Informe um CPF válido, do tipo XXX.XXX.XXX-XX")]
        [Required(ErrorMessage = "O campo CPF deve ser preenchido")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        //[RegularExpression(@"^\d{2}\/\d{2}\/\d{4}$", ErrorMessage = "Informe uma Data de Nascimento válida, do tipo DD/MM/AAAA")]
        [Required(ErrorMessage = "O campo Data de Nascimento deve ser preenchido")]
        [Display(Name = "Data de Nascimento")]
        public DateTime? Nascimento { get; set; }

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

        [Display(Name = "Profissão")]
        public string Profissao { get; set; }


    }
    public class UpdateUserInfoViewModels
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Informe um CPF válido, do tipo XXX.XXX.XXX-XX")]
        [Required(ErrorMessage = "O campo CPF deve ser preenchido")]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O campo Data de Nascimento deve ser preenchido")]
        [Display(Name = "Data de Nascimento")]
        public DateTime? Nascimento { get; set; }

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

        [Display(Name = "Profissão")]
        public string Profissao { get; set; }


    }
    public class DeleteUserInfoViewModels
    {
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "CPF")]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "Data de Nascimento")]
        public DateTime? Nascimento { get; set; }

        [Required]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required]
        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Required]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required]
        [Display(Name = "Estado")]
        public string Estado { get; set; }

        [Display(Name = "Profissão")]
        public string Profissao { get; set; }


    }
}