using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_de_merch.Module;
using Tour_de_merch.Helpers;
using Tour_de_merch.Interface;

namespace Tour_de_merch.Repository
{
    public class JsonTurneRepository : ITurneRepository
    {
        string JsonLocation = "Data/Turne.json";
        public Dictionary<int, Turne> GetAllTurneer()
        {
            return JsonReadWrite.JsonRead<Dictionary<int, Turne>>(JsonLocation);
        }
        public void CreateTurne(Turne item)
        {
            Dictionary<int, Turne> TurneList = GetAllTurneer();
            item.ID = FindID();
            TurneList.Add(item.ID, item);
            JsonReadWrite.JsonWrite(TurneList, JsonLocation);
        }

        public void DeleteTurne(int ID)
        {
            Dictionary<int, Turne> TurneList = GetAllTurneer();
            TurneList.Remove(ID);
            JsonReadWrite.JsonWrite(TurneList, JsonLocation);
        }

        public int FindID()
        {
            int id = 1;
            while (GetAllTurneer().ContainsKey(id))
            {
                id++;
            }
            return id;
        }



        public Turne GetTurne(int ID)
        {
            return GetAllTurneer()[ID];
        }

        public void UpdateTurne(Turne item)
        {
            Dictionary<int, Turne> TurneList = GetAllTurneer();
            TurneList[item.ID] = item; 
            JsonReadWrite.JsonWrite(TurneList, JsonLocation);
        }
    }
}
