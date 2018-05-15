using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewAssign2.ViewModels
{
    public class ProductViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "The Motor name cannot be blank")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Please enter a Motor name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s]*$", ErrorMessage = "Please enter a Motor name made up of only letters and spaces")]
        [Display(Name = "Motor Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The Motor Year cannot be blank")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public string Year { get; set; }
        public string Type { get; set; }

        [Required(ErrorMessage = "The Motor description cannot be blank")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "Please enter a Motor description between 10 and 200 characters in length")]
        [RegularExpression(@"^[a-zA-z0-9'-'\s]*$", ErrorMessage = "Please enter a Motor description made up of only letters and spaces")]
        public string Description { get; set; }

        public decimal Price { get; set; }
        [Required(ErrorMessage = "The Motor price cannot be blank")]
        [Range(0.10, 10000, ErrorMessage = "Please enter a Motor price between 0.10 and 10000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [RegularExpression("[0-9]+(\\.[0-9)][0-9]?)?", ErrorMessage = "The Price must be a number upto two decimal places")]

        [Display(Name = "Bnad Name")]
        public int CategoryID { get; set; }
        public SelectList CategoryList { get; set; }
        [Display(Name = "Motor Images")]
        public List<SelectList> ImageLists { get; set; }
        public string[] ProductImages { get; set; }



    }
}