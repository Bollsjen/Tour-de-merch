using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tour_de_merch.Module
{
    public class Item
    {
        public int Id;
        //AutoId
        public static int AutoId = 1;
        public DateTime Dato { get; set; }
        public string Størrelse { get; set; }
        public List<Item> MoreItems;
        public double Pris { get; set; }
        public string Titel { get; set; }
        public int PåLager { get; set; }


    }
}
