using Application.Dtos;
using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService
    {
         
        public ProductListDto productList { get; set; } 



        public ProductService() 
        {

            productList = new() 
            { 
                DairyProducts = new(),
                Fruits = new(),
                Vegetables = new() 
            }; 
        
        }


        public void Add(ProductDto dto) 
        {
            switch (dto.Type) 
            {

                case 1:
                    productList.Fruits.Add(dto);
                    break;

                case 2:
                    productList.Vegetables.Add(dto);
                    break;

                case 3:
                    productList.DairyProducts.Add(dto);
                    break;

                    default:
                    break;


            }
        
        }



        public ProductListDto GetAll()
        {
            return productList;

        }
    }
}
