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
        public Inventory Inventory;
        public Wallet Wallet;
        public Recipe Recipe;

        //construstor
        public Player()
        {
            Inventory = new Inventory();
            Wallet = new Wallet();
            Recipe = new Recipe();
        }

        //member methods(HAS TO)
        public void BuyInventory()
        {

        }
        public void SetRecipe()
        {
            UserInterface.DisplayRecipe(Recipe);
            string answer = UserInterface.AskNewRecipe();
            if (answer == "yes")
            {
                int howMany;
                double howMuch;
                string item = UserInterface.ItemToReset();
                switch (item)
                {
                    case "lemons":
                    case "lemon":
                    case "Lemons":
                    case "Lemon":
                        howMany = UserInterface.HowMany("Lemons");
                        Recipe.howManyLemons = howMany;
                        break;
                    case "Sugar":
                    case "sugar":
                        howMany = UserInterface.HowMany("Cups of Sugar");
                        Recipe.howMuchSugar = howMany;
                        break;
                    case "Ice":
                    case "ice":
                        howMany = UserInterface.HowMany("Cubes of Ice");
                        Recipe.howManyIceCubes = howMany;
                        break;
                    case "Price":
                    case "price":
                        howMuch = UserInterface.ResetPrice();
                        Recipe.pricePerCup = howMuch;
                        break;
                }
            }

        }
    }
}
