using Microsoft.AspNetCore.Mvc;

namespace NewSuperMarket2025.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            //Este es el controlador que nos lleva a la vista principal de la aplicacion que es Index 
            int numero = 12;
            return View(numero);
        }


        public IActionResult AddProduct() 
        {
            //Creamos un controlador para agregar productos el cual nos llevara a una vista que se llama AddProduct
            return View();
        }
    }
}
