using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStoreApp.Models
{
    public class CartItem
    {
        public int CartItemId { get; set; }

        public Card Card { get; set; }

        public int Amount { get; set; }

        public string CartId { get; set; }
    }
}
