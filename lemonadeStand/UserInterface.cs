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
            Console.WriteLine("Game Play:\n1. Set your recipe for a pitcher of lemonade (A pitcher is about 10 cups)\n2. Set your price per cup\n    HINT: Rmember to check the weather\n3. Buy inventory (Lemons, Sugar, Ice)\n    HINT: make sure you buy enough suplies to get through the day\n\n");
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
        public static string ItemToBuy()
        {
            Console.WriteLine("What item would you like to buy?");
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
        public static void DisplayWallet(Player player)
        {
            Console.WriteLine($"WALLET: {player.Wallet.totalValue}");
        }
        public static void DisplayInventory(Player player)
        {
            Console.WriteLine($"INVENTORY:\n\nCups: {player.Inventory.numberOfCups}\nLemons: {player.Inventory.numberOfLemons}\nSugar(cups): {player.Inventory.cupsOfSugar}\nIce cubes: {player.Inventory.numberOfIceCubes}");
        }
        public static void DisplayRecipe(Recipe recipe)
        {
            Console.WriteLine($"\n\nRECIPE:\nLemons: {recipe.howManyLemons}\nSugar: {recipe.howMuchSugar}\nIce: {recipe.howManyIceCubes}\nPrice: ${recipe.pricePerCup}\n");
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
            Console.WriteLine($"Today's Tempature: {weather.actualDayTemperature}°F\nToday's Forcast: {weather.actualDayForecast}");
        }
    }
}
