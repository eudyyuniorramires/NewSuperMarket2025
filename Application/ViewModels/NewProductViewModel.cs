using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class NewProductViewModel
    {
        [Required(ErrorMessage ="You must enter the name of product ")]
        public required string Name { get; set; }


        public string? Description { get; set; }


        [Required(ErrorMessage ="You must enter the price of product")]
        public required double Price { get; set; }


        [Required(ErrorMessage ="You must enter de type of product")]
        public required int Type { get; set; }
    }
}
