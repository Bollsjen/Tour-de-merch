using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_de_merch.Module;

namespace Tour_de_merch.Interface
{
    public interface ITurneRepository
    {
        public Dictionary<int, Turne> GetAllTurneer();
        public Turne GetTurne(int ID);
        public void DeleteTurne(int ID);
        public void UpdateTurne(Turne item);
        public void CreateTurne(Turne item);
        public int FindID();
    }
}
