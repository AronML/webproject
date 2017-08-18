using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialAspNetIdentity.Security.Models
{
     [Table("MyBasket")]
     public class MyBasket
    {
        public int id { get; set; }
        public string userid { get; set; }
        public int product { get; set; }
        public int quantidade { get; set; }
    }
}
