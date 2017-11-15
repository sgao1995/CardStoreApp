using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class Cart
    {
        private readonly AppDbContext _appDbContext;
        private Cart(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public string CartId { get; set; } //cart's id

        public List<CartItem> CartItems { get; set; } //list of cart items

        public static Cart GetCart(IServiceProvider services)
        {
            //get access to session
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session; 

            //get access to AppDbContext
            var context = services.GetService<AppDbContext>();
            
            //check if there's already a CartId in session, if not create one
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

            //store value of CartId in the session
            session.SetString("CartId", cartId);

            //return new cart
            return new Cart(context) { CartId = cartId };
        }

        public void AddToCart(Card card, int amount)
        {

            var cartItem = _appDbContext.CartItems.SingleOrDefault(s => s.Card.CardId == card.CardId
            && s.CartId == CartId); //get cart item that matches the item that you want to add

            if (cartItem == null) // if no existing item in the cart, add the new item to cart
            {
                cartItem = new CartItem
                {
                    CartId = CartId,
                    Card = card,
                    Amount = 1
                };

                _appDbContext.CartItems.Add(cartItem);
            }
            else //otherwise, just increase the amount of items in the cart
            {
                cartItem.Amount++;
            }
            _appDbContext.SaveChanges();
        }

        public void ClearCart()
        {
            var cartItems = _appDbContext.CartItems.Where(cart => cart.CartId == CartId); //get all cart items

            _appDbContext.CartItems.RemoveRange(cartItems); //remove all items from cart

            _appDbContext.SaveChanges();
        }

        public List<CartItem> GetCartItems()
        {

            return CartItems ?? (CartItems = _appDbContext.CartItems.Where(cart => cart.CartId == CartId).Include(s=> s.Card).ToList());
        }

        public Decimal GetTotalCartPrice()
        {
            var total = _appDbContext.CartItems.Where(c => c.CartId == CartId).Select(c => c.Card.Price * c.Amount).Sum();
            return total;
        }
    }
}
