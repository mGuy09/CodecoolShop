﻿using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Codecool.CodecoolShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ILogger<ProductController> _logger;
        public ProductService ProductService { get; set; }
        public Cart cart = Models.Cart.Instance;
        public CartController(ILogger<ProductController> logger)
        {
            _logger = logger;
            ProductService = new ProductService(
                ProductDaoMemory.GetInstance(),
                ProductCategoryDaoMemory.GetInstance());
        }

        [HttpGet("/Cart")]
        public IActionResult Cart()
        {
            return View(cart.Products);
        }
        [HttpGet("/Cart/AddToCart")]
        public IActionResult AddToCart(int id)
        {
            cart.Add(ProductService.GetProductById(id));
            return Redirect("/Cart");
        }
    }
}
