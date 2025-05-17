using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repositories
{
    public class ProductRepository
    {

        private ProductRepository() 
        {
        
        }


        public static ProductRepository Instance { get; } = new ();

        public ProductListDto productList { get; set; } = new() { DairyProducts = new(), Fruits = new(), Vegetables = new(), };
    }
}
