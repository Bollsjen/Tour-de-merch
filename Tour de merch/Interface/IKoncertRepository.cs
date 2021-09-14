using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_de_merch.Module;

namespace Tour_de_merch.Interface
{
    public interface IKoncertRepository
    {
        public Dictionary<int, Koncert> GetAllKoncerts();
        public List<Koncert> GetAllKoncertsFromTurne(Turne turne);
        public Koncert GetKoncert(int ID);
        public void DeleteKoncert(int ID);
        public void UpdateKoncert(Koncert item);
        public void CreateKoncert(Koncert item);
        public int FindID();
    }
}
