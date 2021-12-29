using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingCartSample.Models
{
    public partial class CartInformation
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual UserInformation User { get; set; }
    }
}
