using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_de_merch.Module;

namespace Tour_de_merch.Interface
{
    public interface IItemRepository
    {
        public Dictionary<int, Item> GetAllItems();
        public Item GetItem(int ID);
        public void DeleteItem(int ID);
        public void UpdateItem(Item item);
        public void CreateItem(Item item);
        public int FindID();
    }
}
