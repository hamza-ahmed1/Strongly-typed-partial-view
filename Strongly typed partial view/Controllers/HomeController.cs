using Microsoft.AspNetCore.Mvc;
using Strongly_typed_partial_view.Models;
using System.Diagnostics;


namespace Strongly_typed_partial_view.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          
            return View();
        }
        public IActionResult Product()
        {
            List<Product> ProductList = new List<Product>()           {
                new Product {ProductId=1,ProductName="Product 1",ProductDescription="Description 1",ProductImage="~/images/earphone.jpg"},
                 new Product {ProductId=2,ProductName="Product 2",ProductDescription="Description 2",ProductImage="~/images/shoe.jpg"},
                  new Product {ProductId=3,ProductName="Product 3",ProductDescription="Description 3",ProductImage="~/images/camera.jpg"}
            };
            return View(ProductList);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}