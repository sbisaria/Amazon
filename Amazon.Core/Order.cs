using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Core
{
    public class Order
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public Payment PaymentDeatils { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public ShippingInfo ShippingInfo { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Status { get; set; }
    }
}
