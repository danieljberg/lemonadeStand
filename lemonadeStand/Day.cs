using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Day
    {
        //member variables(HAS A)
        public int today;
        public Customer customerBase;
        public Recipe recipe;
        public Weather Weather;
        public UserInterface UserInterface;

        //construstor
        public Day()
        {
            Weather = new Weather();
            UserInterface = new UserInterface();
        }
        

        //member methods(HAS TO)
        public void GenerateCustomerBase()
        {
            
        }
        public void GetTheWeather()
        {
            UserInterface.DisplayWeather(Weather.todayTempature, Weather.todayForecast);
        }
        public void GetTheRecipe()
        {

        }
    }
}
