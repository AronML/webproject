using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialAspNetIdentity.Security.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string info { get; set; }
        public int value { get; set; }
        
    }
}

