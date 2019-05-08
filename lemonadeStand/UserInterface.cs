using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public static class UserInterface
    {
        //member variables(HAS A)


        //construstor


        //member methods(HAS TO)
        public static string GetName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        public static int HowMany(string itemToCount)
        {
            Console.WriteLine($"How many {itemToCount} do you want");
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
        public static string ItemToBuy()
        {
            Console.WriteLine("What item would you like to buy?");
            string itemToBuy = Console.ReadLine();
            return itemToBuy;
        }
        public static void DisplayWallet(Player player)
        {
            Console.WriteLine($"WALLET: {player.wallet.totalValue}");
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine($"INVENTORY:\n\nCups: {player.inventory.numberOfCups}\nLemons: {player.inventory.numberOfLemons}\nSugar(cups): {player.inventory.cupsOfSugar}\nIce cubes: {player.inventory.numberOfIceCubes}");
        }
        public static void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine($"RECIPE:\n\nLemons: {recipe.howManyLemons}\nSugar: {recipe.howMuchSugar}\nIce: {recipe.howManyIceCubes}");
        }
        public static void DisplayActualWeather()
        {
            Console.WriteLine($"Today's Tempature: {todayTempature}°F\nToday's Forcast: {todayForcast}");
        }
    }
}
