using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Weather
    {
        //member variables(HAS A)
        public int todayTempature;
        public string todayForecast;
            //public int tomorrowTempature;
            //public string tomorrowForcast;

        public List<string> weatherForecastList;

        //construstor
        public Weather()
        {
            weatherForecastList = new List<string>() { "Sunny", "Partly Sunny", "Partly Cloudy", "Overcast", "Rainy" };
            todayTempature = GetTempature();
            todayForecast = GetForecast(weatherForecastList);
        } 

        //member methods(HAS TO)
        public int GetTempature()
        {
            Random randomTemp = new Random();
            todayTempature = randomTemp.Next(60, 103);
            return todayTempature;
        }
        public string GetForecast(List<string> weatherForecast)
        {
            Random randomNumber = new Random();
            int indexNumber = randomNumber.Next(5);
            todayForecast = weatherForecast.ElementAt(indexNumber);
            return todayForecast;
        }
    }
}
