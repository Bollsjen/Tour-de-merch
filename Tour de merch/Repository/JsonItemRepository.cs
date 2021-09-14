using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_de_merch.Interface;
using Tour_de_merch.Module;
using Tour_de_merch.Helpers;

namespace Tour_de_merch.Repository
{
    public class JsonItemRepository : IItemRepository
    {
        string JsonLocation = "Data/Item.json";
        public Dictionary<int, Item> GetAllItems()
        {
            return JsonReadWrite.JsonRead<Dictionary<int, Item>>(JsonLocation);
        }
        public void CreateItem(Item item)
        {
            Dictionary<int, Item> ItemsList = GetAllItems();
            item.Id = FindID();
            ItemsList.Add(item.Id, item);
            JsonReadWrite.JsonWrite(ItemsList, JsonLocation);
        }

        public void DeleteItem(int ID)
        {
            Dictionary<int, Item> ItemsList = GetAllItems();
            ItemsList.Remove(ID);
            JsonReadWrite.JsonWrite(ItemsList, JsonLocation);
        }

        public int FindID()
        {
            int id = 1;
            while (GetAllItems().ContainsKey(id))
            {
                id++;
            }
            return id;
        }

        public Item GetItem(int ID)
        {
            return GetAllItems()[ID];
        }

        public void UpdateItem(Item item)
        {
            Dictionary<int, Item> ItemsList = GetAllItems();
            ItemsList[item.Id] = item;
            JsonReadWrite.JsonWrite(ItemsList, JsonLocation);
        }
    }
}
