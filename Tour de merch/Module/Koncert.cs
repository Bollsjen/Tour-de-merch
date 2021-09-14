using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tour_de_merch.Module;

namespace Tour_de_merch.Module
{
    public class Koncert
    {
        public int Id { get; set; }
        //AutoId
        public static int AutoId = 1;
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string By { get; set; }
        public string Spillested { get; set; }
        public Module.Turne Turne { get; set; }
        public Module.Turne TurnePlan { get; set; }
        public double Fortjeneste { get; set; }
        public Dictionary<Item, int> AntalItemsSolgt { get; set; }
        public double profit
        {
            get
            {
                double totalprofit = 0;
                foreach (var i in AntalItemsSolgt)
                {
                    totalprofit += i.Key.Pris * i.Value;
                }
                return totalprofit;
            }
        }
    }
}
