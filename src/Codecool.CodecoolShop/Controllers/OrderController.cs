using Codecool.CodecoolShop.Daos.Implementations;
using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Codecool.CodecoolShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        public OrderService OrderService { get; set; }
        public Cart cart = Models.Cart.Instance;
        public Client client = Models.Client.Instance;
        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
            OrderService = new OrderService(
                OrderDaoMemory.GetInstance();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult OrderRegistered(int id)
        {
            order.Add(ProductService.GetProductById(id));
            return Redirect("/Cart");
        }
    }
