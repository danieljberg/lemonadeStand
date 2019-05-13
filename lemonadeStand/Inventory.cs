using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Inventory
    {
        //member variables(HAS A)
        public int numberOfCups;
        public int numberOfLemons;
        public int cupsOfSugar;
        public int numberOfIceCubes;

        //construstor
        public Inventory()
        {
            numberOfCups = 0;
            numberOfLemons = 0;
            cupsOfSugar = 0;
            numberOfIceCubes = 0;

        }

        //member methods(HAS TO)
        public void SubtractRecipeFromInventory(Day day, Player player)
        {            
            numberOfLemons -= player.Recipe.howManyLemons;
            cupsOfSugar -= player.Recipe.howMuchSugar;
            numberOfIceCubes -= player.Recipe.howManyIceCubes;
        }
        public void SubtractFromInventory(Day day, Player player)
        {
            numberOfCups -= day.numberWillingToBuy;
            numberOfIceCubes -= player.Recipe.howManyIceCubes * day.numberWillingToBuy;
        }

                //public int SubtractInventoryItem(int item)
                //{
                //    return item--;

                //}
                //public int AddToInventoryItem(int item)
                //{
                //    return item++;
                //}
    }
}
