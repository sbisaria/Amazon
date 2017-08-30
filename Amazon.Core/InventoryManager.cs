using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.Core
{
    public class InventoryManager
    {
        private Inventory _inventory;

        public InventoryManager()
        {
            _inventory = new Inventory();
        }

        public bool IsItemAvailable(string itemId)
        {
            var item = _inventory.Items.FirstOrDefault(x => x.Id.Equals(itemId));
            if (item != null)
                return item.Count > 0;
            return false;
        }

        public bool AddItem(Item item)
        {
            throw new NotImplementedException();
        }
        public bool RemoveItem(Item item)
        {
            throw new NotImplementedException();
        }
        
        public bool UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }

        public List<Item> GetAllIems()
        {
            throw new NotImplementedException();
        }
    }
}
