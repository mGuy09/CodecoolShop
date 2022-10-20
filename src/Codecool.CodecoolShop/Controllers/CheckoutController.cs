using Codecool.CodecoolShop.Models;
using Codecool.CodecoolShop.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Codecool.CodecoolShop.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Checkout()
        {
            return View();
        }

       
        public IActionResult InfoForm()
        {
            return Redirect("/Checkout");
        }

        [HttpGet("/Checkout/Order")]
        public IActionResult AddInfoForm(Checkout checkout)
        {
            throw new NotImplementedException();
        }

        [HttpGet("/Checkout/Confirmation")]
        public IActionResult PaymentConfirmation()
        {
            return View();
        }
    }
}
