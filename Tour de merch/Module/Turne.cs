using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_de_merch.Module;

namespace Tour_de_merch.Module
{
    public class Turne
    {
        public int ID { get; set; }
        public int AutoId { get ;  set; }
        public string Navn { get; set;}
        public List<Koncert> TurnePlan { get; set; }
        public DateTime TurneStart { get; set; }
        public DateTime TurneSlut { get; set; }
        public double Fortjeneste { get; set; }

        
        
       /* public turne(int id, int autoid, string navn, DateTime turnestart, DateTime turneslut, double fortjeneste)
        {
            ID = id;
            AutoId = autoid;
            Navn = navn;
            TurneStart = turnestart;
            TurneSlut = turneslut;
            Fortjeneste = fortjeneste;
        }*/

    }
}
