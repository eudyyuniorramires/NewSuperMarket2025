using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProductViewModels
    {

        public required string Name { get; set; }

        public string? Description { get; set; }


        public required double Price { get; set; }

        public required int Type { get; set; }
    }
}
