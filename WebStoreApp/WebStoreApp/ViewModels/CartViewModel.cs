using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStoreApp.Models;

namespace WebStoreApp.ViewModels
{
    public class CartViewModel
    {
        public Cart Cart { get; set; }
        public decimal CartTotalPrice { get; set; }
    }
}
