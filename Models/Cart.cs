using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Cart
    {
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? UserId { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }
        public int? Quantity { get; set; }
        public decimal? TotalPrice { get; set; }
        public string ProductImage { get; set; }

        public Products Product { get; set; }
        public Users User { get; set; }
    }
}
