using System;
using System.Collections.Generic;

namespace WebApplication3.Models
{
    public partial class Orders
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string OrderNo { get; set; }
        public decimal? TotalPrice { get; set; }
        public string OrderStatus { get; set; }
        public string ShippingAddress { get; set; }
        public string Landmark { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int? Pincode { get; set; }
        public string ProductImage { get; set; }
        public int? Quantity { get; set; }
        public string Comments { get; set; }
        public int? ProductId { get; set; }

        public Products Product { get; set; }
        public Users User { get; set; }
    }
}
