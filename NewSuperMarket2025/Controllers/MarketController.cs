using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;

namespace NewSuperMarket2025.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            List<ProductViewModels> productFruits = new()
            {
                new(){Name = "Fresa",Price = 56.4,Type =1,Description="Es una fruta"},
                new(){Name = "Queso",Price = 5.4,Type =1,Description="Es un lacteo"},
                new(){Name = "Sandia",Price = 12.4,Type =1,Description="Es una fruta"},
                new(){Name = "Espaguetis",Price = 54.4,Type =1,Description="Es pasta"},
            };


            List<ProductViewModels> productVegetables = new()
            {
                new(){Name = "Fresa",Price = 56.4,Type =1,Description="Es una fruta"},
                new(){Name = "Queso",Price = 5.4,Type =2,Description="Es un lacteo"},
                new(){Name = "Sandia",Price = 12.4,Type =1,Description="Es una fruta"},
                new(){Name = "Espaguetis",Price = 54.4,Type =3,Description="Es pasta"},
            };

            List<ProductViewModels> productDairy = new()
            {
                new(){Name = "Fresa",Price = 56.4,Type =1,Description="Es una fruta"},
                new(){Name = "Queso",Price = 5.4,Type =2,Description="Es un lacteo"},
                new(){Name = "Sandia",Price = 12.4,Type =1,Description="Es una fruta"},
                new(){Name = "Espaguetis",Price = 54.4,Type =3,Description="Es pasta"},
            };




            ProductListViewModel ProductList = new() { Fruists = productFruits, DairyProducts = productDairy, Vegetables = productVegetables };


            return View(products);
        }


        public IActionResult AddProduct() 
        {
            //Creamos un controlador para agregar productos el cual nos llevara a una vista que se llama AddProduct
            return View();
        }
    }
}
