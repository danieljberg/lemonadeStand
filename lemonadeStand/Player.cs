using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Player
    {
        //member variables(HAS A)
        public string name;
        public double profitLoss;
        public Inventory inventory;
        public Wallet wallet;

        //construstor
        public Player()
        {
            inventory = new Inventory();
            wallet = new Wallet();
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
