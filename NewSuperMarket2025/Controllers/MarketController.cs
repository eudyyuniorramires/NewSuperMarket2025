using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;
using Application.Services;
using Application.Dtos;

namespace NewSuperMarket2025.Controllers
{
    public class MarketController : Controller
    {

        private readonly ProductService _productService;    


        public MarketController()
        {
            _productService = new ProductService();
        }
        public IActionResult Index()
        {
            ProductListDto productListDto = _productService.GetAll();
            ProductListViewModel productListViewModel = new()
            {
                DairyProducts = productListDto.DairyProducts.Select(s =>
                new ProductViewModels
                {
                    Description = s.Description,
                    Name = s.Name,
                    Price = s.Price,
                    Type = s.Type


                }).ToList(),
                Fruits = productListDto.Fruits.Select(s =>
                new ProductViewModels
                {
                    Description = s.Description,
                    Name = s.Name,
                    Price = s.Price,
                    Type = s.Type


                }).ToList(),
                Vegetables = productListDto.Vegetables.Select(s =>
                new ProductViewModels
                {
                    Description = s.Description,
                    Name = s.Name,
                    Price = s.Price,
                    Type = s.Type


                }).ToList()
            };


            return View(productListViewModel);
        }


        public IActionResult AddProduct() 
        {
            //Creamos un controlador para agregar productos el cual nos llevara a una vista que se llama AddProduct
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(NewProductViewModel wm)
        {

            if (!ModelState.IsValid) 
            {

                return View(wm);
               
            }

            _productService.Add(new ProductDto()
            {
                Name = wm.Name,
                Description = wm.Description,
                Price = wm.Price,
                Type = wm.Type
            });


            return View();
        }
    }
}
