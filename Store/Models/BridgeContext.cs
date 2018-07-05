using Store.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Store.Models
{
    public class BridgeContext : DbContext
    {
        public BridgeContext(): base("name=DefaultConnection")
        {
        }
        public DbSet<User>      Users    { get; set; }
        public DbSet<Product>   Products { get; set; }
        public DbSet<Cart>      Carts    { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Order>     Orders   { get; set; }

        public System.Data.Entity.DbSet<Store.ViewModels.ShoppingCartViewModel> ShoppingCartViewModels { get; set; }
    }
}