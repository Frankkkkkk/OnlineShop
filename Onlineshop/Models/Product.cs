using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewAssign2.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "The Car name cannot be blank")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter a Model name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s]*$", ErrorMessage = "Please enter a Motor name made up of only letters and spaces")]
        [Display(Name = "Model Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Motor Year cannot be blank")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string Year { get; set; }
        public string Type { get; set; }
        [Required(ErrorMessage = "The Motor price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage = "Please enter a Motor price between 0.10 and 10000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "The Motor description cannot be blank")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Please enter a Motor description between 10 and 200 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s]*$", ErrorMessage = "Please enter a Motor description made up of only letters and spaces")]
        public string Description { get; set; }
        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductImageMapping> ProductImageMappings { get; set; }
    }
}