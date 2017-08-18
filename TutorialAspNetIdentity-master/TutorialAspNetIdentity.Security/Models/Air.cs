using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TutorialAspNetIdentity.Security.Models
{
    [Table("Air")]
    public class Air
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Onn { get; set; }
        public string UserId { get; set; }
        public int Temp { get; set; }
        public int PlaceId { get; set; }
    }
}
