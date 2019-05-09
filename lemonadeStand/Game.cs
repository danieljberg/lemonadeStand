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
        public Store store;
        public List<Day> daysOfWeek;        
        public int daysPlaying;

        //construstor
        public Game()
        {
            Player = new Player();
            daysPlaying = 7;
            daysOfWeek = new List<Day>();
            Random random = new Random();
            for (int i = 0; i < daysPlaying; i++)
            {
                daysOfWeek.Add(new Day(random));
            }
            
        }

        //member methods(HAS TO)
        public void PlayGame()
        {
            Player.name = UserInterface.GetName();
            UserInterface.WelcomeScreen(Player);
            UserInterface.GamePlay();
            UserInterface.DisplayProjectedWeather(daysOfWeek);
            Player.SetRecipe();


            

        }

    }
}
