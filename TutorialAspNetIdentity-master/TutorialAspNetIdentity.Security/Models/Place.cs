using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialAspNetIdentity.Security.Models
{
    [Table("AspNetPlace")]
    public class Place
    {
        
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public bool? Deleted { get; set; }
    }
}
