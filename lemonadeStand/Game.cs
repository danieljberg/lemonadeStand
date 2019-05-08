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
            daysOfWeek = new List<Day>(daysPlaying);
        }

        //member methods(HAS TO)
        public void PlayGame()
        {
            UserInterface.GetName();
            UserInterface.WelcomeScreen(Player);
            UserInterface.GamePlay();
            Player.SetRecipe();


            //daysOfWeek[0].Weather.projectedDayForecast

        }

    }
}
