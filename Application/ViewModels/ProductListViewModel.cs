using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProductListViewModel
    {

        public required List<ProductViewModels> Fruits { get; set; }


        public required List<ProductViewModels> Vegetables { get; set; }


        public required List<ProductViewModels> DairyProducts { get; set; }

        
    }
}
