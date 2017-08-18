using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialAspNetIdentity.Security.Models
{
    [Table("UserInfo")]
    public class UserInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Endereco { get; set; }
        public string Cep { get; set; }
        public string Cpf { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public DateTime? Nascimento { get; set; }
        public string Profissao { get; set; }
        public string noip { get; set; }
        
    }
}
