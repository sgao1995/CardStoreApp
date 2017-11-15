using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStoreApp.Models;
using WebStoreApp.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebStoreApp.Controllers
{
    public class CartController : Controller
    {
        private readonly ICardRepository _cardRepo;
        private readonly Cart _cart;

        public CartController(ICardRepository cardRepo, Cart cart)
        {
            _cardRepo = cardRepo;
            _cart = cart;
        }
        public ViewResult Index()
        {
            var cartItems = _cart.GetCartItems();
            _cart.CartItems = cartItems;

            var cartViewModel = new CartViewModel
            {
                Cart = _cart,
                CartTotalPrice = _cart.GetTotalCartPrice()
            };
            return View(cartViewModel);
        }
    }
}
