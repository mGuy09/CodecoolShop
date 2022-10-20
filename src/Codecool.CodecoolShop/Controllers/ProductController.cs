using System.Diagnostics;
using System.Linq;
using Codecool.CodecoolShop.Daos.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Routing;
using NuGet.Protocol;

namespace Codecool.CodecoolShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductService ProductService { get; set; }
        public Cart cart = Cart.GetInstance();
        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
            ProductService = new ProductService(
                ProductDaoMemory.GetInstance(),
                ProductCategoryDaoMemory.GetInstance());
        }

        public IActionResult Index()
        {
            
            return View(ProductService.GetAllProducts().ToList());
        }

        [HttpGet("/Product/Categories/{id:int}")]
        public IActionResult Categories(int id)
        {
            if (id != 0)
            {
                var products = ProductService.GetProductsForCategory(id);
                return View(products.ToList());
            }
            else
            {
                return View(ProductService.GetAllProducts().ToList());
            }
        }
        [HttpGet("/Product/Cart-Contents")]
        public string GetCartContents()
        {
            return cart.Products.ToJson();
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
