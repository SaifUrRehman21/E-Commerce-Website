using Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.ViewModels
{
    public class ShoppingCartViewModel
    {
        public int ShoppingCartViewModelId { get; set; }
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}