using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class ProductDto
    {

        public required string Name { get; set; }

        public string? Description { get; set; }


        public required double Price { get; set; }

        public required int Type { get; set; }
    }
}
