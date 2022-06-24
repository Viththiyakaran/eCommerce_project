using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_project.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }
        [Display(Name = "ProfilePictureURL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
