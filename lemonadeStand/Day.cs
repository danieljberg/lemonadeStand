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
            //public Recipe recipe;
        public Weather Weather;

        //construstor
        public Day()
        {
            Weather = new Weather();
        }
        

        //member methods(HAS TO)
        public void GenerateCustomerBase()
        {
            
        }
        //public void GetTheWeather()
        //{
        //    UserInterface.DisplayActualWeather(Weather.projectedDayTemperature, Weather.projectedDayForecast);
        //}       
    }
}
