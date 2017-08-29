using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Core
{
    public class Cart
    {
        public List<Item> Items { get; } = new List<Item>();
        public double Total
        {
            get
            {
                return Items.Sum(x => x.Price * x.Count);
            }
        }
    }
}
