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
            Console.Clear();
            return name;
        }
        public static void WelcomeScreen(Player player)
        {
            Console.WriteLine($"Welcome {player.name}, to your 'Lemonade Stand' a game where you are in control of a lemonade stand. Try to make a profit at the end of the week by adjusting your resipe and price of your lemonade to achive the greatest profit. Remember to check the weather because customers will choose to purchus a cup of lemonade based on the temperature and forecast of the day.\n");
        }
        public static void GamePlay()
        {
            Console.WriteLine("Game Play:\n1. Buy inventory (Lemons, Sugar, Ice)\n2. Set your recipe \n3. Set your price per cup\n    HINT: Rmember to check the weather\n\n");
        }
        public static void EnterToContinue()
        {
            Console.WriteLine("Hit enter to continue");
            Console.ReadLine();
        }
        public static int HowMany(string itemToCount)
        {
            Console.WriteLine($"How many {itemToCount} do you want?");
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
        public static int SetHowMany(string itemToCount)
        {
            Console.WriteLine($"Set {itemToCount} to?");
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
        public static string AskToBuyInventory()
        {
            Console.WriteLine("Would you like to buy some inventory? ('yes' or 'no')");
            string answer = Console.ReadLine();
            return answer;
        }
        public static string ItemToBuy()
        {
            Console.WriteLine("\nWhat item would you like to buy?");
            string itemToBuy = Console.ReadLine();
            return itemToBuy;
        }
        public static string AskNewRecipe()
        {
            Console.WriteLine("Would you like to set new item for your recipe? ('yes' or 'no')");
            string answer = Console.ReadLine();
            return answer;
        }
        public static string ItemToReset()
        {
            Console.WriteLine("What item would you like to change?");
            string itemToReset = Console.ReadLine();
            return itemToReset;
        }
        public static double ResetPrice()
        {
            Console.WriteLine("Enter new price:");
            double newPrice = double.Parse(Console.ReadLine());
            return newPrice;
        }        
        public static void DisplayInventoryInfo()
        {
            Console.WriteLine("Now it's time to buy your inventory...\nTake in to account you will be making pitchers of lemonade to sell to all of your customers. Each pitcher will make about 10 cups of lemonade. You will encounter anywhere from 60 to 120 customers on any given day based on the current days temperature. Each customer will decide to buy a cup of lemonade based on the weather and price you set.");
        }
        public static void DisplayWallet(Player player)
        {
            Console.WriteLine($"WALLET: ${player.Wallet.totalValue}\n");
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine($"INVENTORY:\nCups: {player.Inventory.numberOfCups}\nLemons: {player.Inventory.numberOfLemons}\nSugar(in cups): {player.Inventory.cupsOfSugar}\nIce cubes: {player.Inventory.numberOfIceCubes}");
        }
        public static void DisplayStorePrice(Store store)
        {
            Console.WriteLine($"\nPRICE PER ITEM:\nCups: ${store.cupPrice}\nLemons: ${store.lemonPrice}\nSugar: {store.sugarPrice}\nIce: ${store.icePrice}\n");
        }
        public static void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine($"\nRECIPE:\nLemons: {recipe.howManyLemons}\nSugar: {recipe.howMuchSugar}\nIce: {recipe.howManyIceCubes}\nPrice: ${recipe.pricePerCup}\n");
        }
        public static void DisplayProjectedWeather(List<Day> daysOfWeek)
        {
            Console.WriteLine($"WEATHER FORECAST FOR THE WEEK:\nDAY 1\t\tDAY 2\t\tDAY 3\t\tDAY 4\t\tDAY 5\t\tDAY 6\t\tDAY 7");
            for (int i = 0; i < daysOfWeek.Count; i++)
            {
                Console.Write($"{daysOfWeek[i].Weather.projectedDayTemperature}°F\t\t");                
            }
            Console.WriteLine();
            for (int i = 0; i < daysOfWeek.Count; i++)
            {
                Console.Write($"{daysOfWeek[i].Weather.projectedDayForecast}\t");
            }
        }
        public static void DisplayActualWeather(Weather weather)
        {
            Console.WriteLine($"Today's Actual Tempature: {weather.actualDayTemperature}°F\nToday's Actual Forcast: {weather.projectedDayForecast}");
        }
    }
}
