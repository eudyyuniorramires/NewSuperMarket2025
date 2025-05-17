using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ProductListDto
    {
        public required List<ProductDto> Fruits { get; set; }
        public required List<ProductDto> Vegetables { get; set; }
        public required List<ProductDto> DairyProducts { get; set; }
    }
}
