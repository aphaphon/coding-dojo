using System.Collections.Generic;

namespace WebApi.Models
{
    public class CartInfo
    {
        public double TotalPrice { get; set; }
        public List<string> ProductIds { get; set; }
    }
    
    public class CartDetail
    {
        public double TotalPrice { get; set; }
        public List<ProductInfo> Products { get; set; }
    }
}