using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewAssign2.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "The Band name cannot be blank")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Please enter a Make name between 3 and 50 characters in length")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9''-'\s]*$", ErrorMessage = "Please enter a Make name beginning with a capital letter and enter only letters and spaces.")]
        [Display(Name = "Band Name")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}