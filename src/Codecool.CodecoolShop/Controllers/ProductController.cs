using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Codecool.CodecoolShop.Daos;
using Codecool.CodecoolShop.Daos.Implementations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;

namespace Codecool.CodecoolShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductService ProductService { get; set; }
        private Cart _cart = new Cart();
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
            var products = ProductService.GetProductsForCategory(id);
            return View(products.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet("/Product/Cart")]
        public IActionResult Cart()
        {
            return View(_cart);
        }

        public void AddToCart(Product product)
        {
            _cart.Add(product);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
