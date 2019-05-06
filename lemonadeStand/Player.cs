using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Player
    {
        //member variables(HAS A)
        public string name;
        public double profitLoss;
        public Inventory Inventory;
        public UserInterface UserInterface;

        //construstor
        public Player()
        {
            Inventory = new Inventory();
            UserInterface = new UserInterface();
        }

        //member methods(HAS TO)
        public void BuyInventory()
        {

        }
        public void SetNewRecipe()
        {

        }
    }
}
