using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Products
    {
        public Products()
        {
            Cart = new HashSet<Cart>();
            Orders = new HashSet<Orders>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public int? Quantity { get; set; }
        public string Status { get; set; }
        public string Image { get; set; }

        public ICollection<Cart> Cart { get; set; }
        public ICollection<Orders> Orders { get; set; }
    }
}
