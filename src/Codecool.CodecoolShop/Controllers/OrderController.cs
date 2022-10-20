using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace Codecool.CodecoolShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        public OrderService OrderService { get; set; }
        public static Cart cart = Models.Cart.GetInstance();
        public static Client client = Models.Client.GetInstance();
        public Order order = new(client, cart);
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
            OrderService = new OrderService(OrderDaoMemory.GetInstance());
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderRegistered(int id)
        {
            throw new NotImplementedException();
        }
    }
}