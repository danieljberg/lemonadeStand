using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Recipe
    {
        //member variables(HAS A)
        public int howManyLemons;
        public int howMuchSugar;
        public int howManyIceCubes;
        public double pricePerCup;

        //construstor
        public Recipe()
        {
                //UserInterface = new UserInterface();
            howManyLemons = 4;
            howMuchSugar = 4;
            howManyIceCubes = 4;
            pricePerCup = .50;
        }

        //member methods(HAS TO)

    }
}
