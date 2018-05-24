using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Give.Models
{
    public class Recipient
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [Column(TypeName = "varchar")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [Column(TypeName = "varchar")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Address")]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Household Size")]
        [Column(TypeName = "int")]
        public int HouseHoldSize { get; set; }

        [Required]
        [Display(Name = "About Me")]
        [Column(TypeName = "varchar")]
        public string AboutMe { get; set; }



        public string Name
        {
            get
            {
                return string.Format("{0} {1}", this.FirstName, this.LastName);
            }
        }
        public virtual ApplicationUser User { get; set; }
        public string ApplicationUserId { get; set; }
    }
}
   
