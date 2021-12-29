using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCartSample.Models
{
    public class CartInformationModel
    {
        public int CartProductDetailsId { get; set; }
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int UserId { get; set; }
        public string productTitle { get; set; }

    }
}
