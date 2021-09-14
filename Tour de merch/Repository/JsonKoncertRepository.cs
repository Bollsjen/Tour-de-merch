using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_de_merch.Interface;
using Tour_de_merch.Module;
using Tour_de_merch.Helpers;

namespace Tour_de_merch.Repository
{
    public class JsonKoncertRepository : IKoncertRepository
    {
        string JsonLocation = "Data/Koncert.json";
        public Dictionary<int, Koncert> GetAllKoncerts()
        {
            return JsonReadWrite.JsonRead<Dictionary<int, Koncert>>(JsonLocation);
        }

        public List<Koncert> GetAllKoncertsFromTurne(Turne turne)
        {
            List<Koncert> koncerter = new List<Koncert>();
            Dictionary<int, Koncert> koncerterDict = GetAllKoncerts();

            foreach(Koncert koncert in koncerterDict.Values)
            {
                if (koncert.Turne == turne)
                    koncerter.Add(koncert);
            }

            return koncerter;
        }
        public void CreateKoncert(Koncert item)
        {
            Dictionary<int, Koncert> KoncertList = GetAllKoncerts();
            item.Id = FindID();
            KoncertList.Add(item.Id, item);
            JsonReadWrite.JsonWrite(KoncertList, JsonLocation);
        }

        public void DeleteKoncert(int ID)
        {
            Dictionary<int, Koncert> KoncertList = GetAllKoncerts();
            KoncertList.Remove(ID);
            JsonReadWrite.JsonWrite(KoncertList, JsonLocation);
        }



        public int FindID()
        {
            int id = 1;
            while(GetAllKoncerts().ContainsKey(id))
            {
                id++;
            }
            return id;
        }

        public Koncert GetKoncert(int ID)
        {
            return GetAllKoncerts()[ID];
        }

        public void UpdateKoncert(Koncert item)
        {
            Dictionary<int, Koncert> KoncertList = GetAllKoncerts();
            KoncertList[item.Id] = item;
            JsonReadWrite.JsonWrite(KoncertList, JsonLocation);
        }

        public void SellItem(int KoncertID, Item item, int Amount)
        {
            GetKoncert(KoncertID).AntalItemsSolgt[item] += Amount;
        }
    }
}
