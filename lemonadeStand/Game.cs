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
        public void PlayGame()
        {
            Player.name = UserInterface.GetName();
            UserInterface.WelcomeScreen(Player);
            UserInterface.GamePlay();
            UserInterface.EnterToContinue();
            Console.Clear();
            UserInterface.DisplayInventoryInfo();
            UserInterface.EnterToContinue();
            Console.Clear();
            UserInterface.DisplayProjectedWeather(daysOfWeek);
            UserInterface.DisplayStorePrice(Store);
            UserInterface.DisplayWallet(Player);
            UserInterface.DisplayInventory(Player);

            string answer = UserInterface.AskToBuyInventory();            
            while (answer == "yes")
            {
                Store.SellItem(Player);
                Console.Clear();
                UserInterface.DisplayProjectedWeather(daysOfWeek);
                UserInterface.DisplayStorePrice(Store);
                UserInterface.DisplayWallet(Player);
                UserInterface.DisplayInventory(Player);
                answer = UserInterface.AskToBuyInventory();
            }
            UserInterface.EnterToContinue();
            Console.Clear();
            UserInterface.DisplayProjectedWeather(daysOfWeek);
            UserInterface.DisplayRecipe(Player.Recipe);
            answer = UserInterface.AskNewRecipe();
            while (answer == "yes")
            {
                Player.SetRecipe();
                Console.Clear();
                UserInterface.DisplayProjectedWeather(daysOfWeek);
                UserInterface.DisplayRecipe(Player.Recipe);
                answer = UserInterface.AskNewRecipe();
                
            }
            

        }
    }
}
