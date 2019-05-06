using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Inventory
    {
        //member variables(HAS A)
        public int numberOfCups;
        public int numberOfLemons;
        public int cupsOfSugar;
        public int numberOfIceCubes;

        //construstor


        //member methods(HAS TO)
        public int SubtractInventoryItem(int item)
        {
            return item--;

        }
        public int AddToInventoryItem(int item)
        {
            return item++;
        }
    }
}
