using Codecool.CodecoolShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace Codecool.CodecoolShop.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult InfoForm()
        {
            return View(Checkout().Products);
        }
    }
}
