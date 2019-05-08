using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Day
    {
        //member variables(HAS A)
        public int daysPlaying;
            //public Customer customerBase;        
        public Weather Weather;
        public Recipe Recipe;

        //construstor
        public Day()
        {
            Weather = new Weather();
            Recipe = new Recipe();
        }
        

        //member methods(HAS TO)
        public void GenerateCustomerBase()
        {
            Customer customer = new Customer(Weather, Recipe);
        }
        //public void GetTheWeather()
        //{
        //    UserInterface.DisplayActualWeather(Weather.projectedDayTemperature, Weather.projectedDayForecast);
        //}       
    }
}
