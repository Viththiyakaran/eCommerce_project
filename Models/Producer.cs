using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerce_project.Models
{
    public class Producer
    {
        [Key]
        public int ProducerID { get; set; }
        [Display(Name = "ProfilePicture")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
