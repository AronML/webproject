using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialAspNetIdentity.Security.Models
{
    [Table("AspNetObj")]
    public class Obj
    {

        [Key]
        public int Id { get; set; }
        public string NameActivated { get; set; }
        public string NameDesativated { get; set; }
        public string userId { get; set; }
        public bool StatusObj { get; set; }
        public int Place { get; set; }
        public bool deleted { get; set; }
    }
}
