using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Game
    {
        //member variables(HAS A)
        public Player Player;
        public Store Store;
        public List<Day> daysOfWeek;        
        public int daysPlaying;
        public double todaysProfit;
        public double totalProfit;

        //construstor
        public Game()
        {
            Random random = new Random();
            Player = new Player();
            Store = new Store();
            daysPlaying = 7;
            daysOfWeek = new List<Day>();
            
            for (int i = 0; i < daysPlaying; i++)
            {
                daysOfWeek.Add(new Day(Player, random));
            }
            
        }

        //member methods(HAS TO)
        public double todayProfit(Day day, Player player)
        {
            double profit = day.numberWillingToBuy * player.Recipe.pricePerCup;
            player.Wallet.totalValue += profit;
            return profit;
        }
        public void PlayGame()
        {            
            Player.name = UserInterface.GetName();
            UserInterface.WelcomeScreen(Player);
            UserInterface.GamePlay();
            UserInterface.EnterToContinue();
            Console.Clear();
            for (int i = 0; i < daysPlaying; i++)
            {
                Console.Clear();
                UserInterface.DisplayProjectedWeather(daysOfWeek);
                Console.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~  DAY {i+1}  ~~~~~~~~~~~~~~~~~~~~~~~~~");
                UserInterface.DisplayActualWeather(daysOfWeek[i].Weather);
                string answer = UserInterface.AskToBuyInventory();
                while (answer != "yes" && answer != "no")
                {
                    answer = UserInterface.AskToBuyInventory();
                }
                while (answer == "yes")
                {                    
                    Console.Clear();
                    UserInterface.DisplayProjectedWeather(daysOfWeek);
                    Console.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~  DAY {i + 1}  ~~~~~~~~~~~~~~~~~~~~~~~~~");
                    UserInterface.DisplayActualWeather(daysOfWeek[i].Weather);
                    UserInterface.DisplayStorePrice(Store);
                    UserInterface.DisplayWallet(Player);
                    UserInterface.DisplayInventory(Player);
                    Store.SellItem(Player);
                    Console.Clear();
                    UserInterface.DisplayProjectedWeather(daysOfWeek);
                    Console.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~  DAY {i + 1}  ~~~~~~~~~~~~~~~~~~~~~~~~~");
                    UserInterface.DisplayActualWeather(daysOfWeek[i].Weather);
                    UserInterface.DisplayStorePrice(Store);
                    UserInterface.DisplayWallet(Player);
                    UserInterface.DisplayInventory(Player);
                    answer = UserInterface.AskToBuyInventory();
                }
                answer = UserInterface.AskNewRecipe();
                while (answer != "yes" && answer != "no")
                {
                    answer = UserInterface.AskNewRecipe();
                }
                while (answer == "yes")
                {                    
                    Console.Clear();
                    UserInterface.DisplayProjectedWeather(daysOfWeek);
                    Console.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~  DAY {i + 1}  ~~~~~~~~~~~~~~~~~~~~~~~~~");
                    UserInterface.DisplayActualWeather(daysOfWeek[i].Weather);
                    UserInterface.DisplayInventory(Player);
                    UserInterface.DisplayRecipe(Player.Recipe);
                    Player.SetRecipe();
                    Console.Clear();
                    UserInterface.DisplayProjectedWeather(daysOfWeek);
                    Console.WriteLine($"\n~~~~~~~~~~~~~~~~~~~~~~~~~  DAY {i + 1}  ~~~~~~~~~~~~~~~~~~~~~~~~~");
                    UserInterface.DisplayActualWeather(daysOfWeek[i].Weather);
                    UserInterface.DisplayInventory(Player);
                    UserInterface.DisplayRecipe(Player.Recipe);
                    answer = UserInterface.AskNewRecipe();
                    
                }
                for (int j = 0; j < daysOfWeek[i].numberWillingToBuy/10; j++)
                {
                    Player.Inventory.SubtractRecipeFromInventory(daysOfWeek[i], Player);
                }
                Player.Inventory.SubtractFromInventory(daysOfWeek[i], Player);
                todaysProfit = todayProfit(daysOfWeek[i], Player);
                totalProfit += todaysProfit;
                UserInterface.DisplayEndOfDayReport(todaysProfit, daysOfWeek[i], totalProfit);
                UserInterface.EnterToContinue();
            }
            
        }
    }
}
