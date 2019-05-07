using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Store
    {
        //member variables(HAS A)
        public double cupPrice;
        public double lemonPrice;
        public double sugarPrice;
        public double icePrice;

        //construstor
        public Store()
        {
            cupPrice = 0.03;
            lemonPrice = 1.00;
            sugarPrice = 0.07;
            icePrice = 0.01;
        }

        //member methods(HAS TO)
        public void SellItem(Player player)
        {
            double totalPrice;
            string itemToBuy = UserInterface.ItemToBuy();
            int howMany = UserInterface.HowMany(itemToBuy);
            switch (itemToBuy)
            {
                case "cups":
                case "cup":
                    totalPrice = CalculateTotalPrice(cupPrice, howMany);
                    player.inventory.numberOfCups += howMany;
                    player.wallet.totalValue -= totalPrice;
                    break;
                case "lemons":
                case "lemon":
                    totalPrice = CalculateTotalPrice(lemonPrice, howMany);
                    player.inventory.numberOfLemons += howMany;
                    player.wallet.totalValue -= totalPrice;
                    break;
                case "sugar":
                case "sugars":
                    totalPrice = CalculateTotalPrice(sugarPrice, howMany);
                    player.inventory.cupsOfSugar += howMany;
                    player.wallet.totalValue -= totalPrice;
                    break;
                case "ice":
                    totalPrice = CalculateTotalPrice(icePrice, howMany);
                    player.inventory.numberOfIceCubes += howMany;
                    player.wallet.totalValue -= totalPrice;
                    break;
                default:
                    itemToBuy = UserInterface.ItemToBuy();
                    break;
            }            
        }
        public double CalculateTotalPrice(double item, int howMany)
        {
            double totalPrice = item * howMany;
            return totalPrice;
        }
    }
}
