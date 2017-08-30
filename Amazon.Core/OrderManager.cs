using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Core
{
    public class OrderManager
    {
        private List<Order> Orders { get; } = new List<Order>();

        public Order PlaceOrder(Cart cart, CreditCard card, Address address, string customerId)
        {
            throw new NotImplementedException();
        }

        public string GetOrderStatus(string orderId)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllItemsPurchasedByCutomer(string customerId)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllItemsInOrder(string orderId)
        {
            throw new NotImplementedException();
        }
    }
}
