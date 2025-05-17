using Application.Dtos;
using Application.Enum;
using Application.Repositories;
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
         
       

        public void Add(ProductDto dto) 
        {
            switch (dto.Type) 
            {

                case (int)ProductType.FRUITS:
                    ProductRepository.Instance.productList.Fruits.Add(dto);
                    break;

                case (int)ProductType.VEGETABLES:
                    ProductRepository.Instance.productList.Vegetables.Add(dto);
                    break;

                case (int)ProductType.DAIRY_PRODUCTS:
                    ProductRepository.Instance.productList.DairyProducts.Add(dto);
                    break;

                    default:
                    break;

            }
        
        }


        public ProductListDto GetAll()
        {
            return ProductRepository.Instance.productList;

        }
    }
}
