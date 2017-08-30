using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Core
{
    public class CartManager
    {
        private Cart _cart;
        public CartManager()
        {
            _cart = new Cart();
        }
        public bool AddCartItem(Item item)
        {
            throw new NotImplementedException();
        }
        public bool DeleteCartItem(Item item)
        {
            throw new NotImplementedException();
        }
        public List<Item> GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}
