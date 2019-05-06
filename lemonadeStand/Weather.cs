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
        public string todayForcast;

        //public int tomorrowTempature;
        // public string tomorrowForcast;

        public List<string> weatherForcast;

        //construstor
        public Weather()
        {
            weatherForcast = new List<string>() { "Sunny", "Partly Sunny", "Partly Cloudy", "Overcast", "Rainy" };
        } 

        //member methods(HAS TO)
        public int getTempature()
        {
            Random randomTemp = new Random();
            todayTempature = randomTemp.Next(60, 103);
            return todayTempature;
        }
        public string getForcast(List<string> weatherForcast)
        {
            Random randomNumber = new Random();
            int indexNumber = randomNumber.Next(5);
            todayForcast = weatherForcast.ElementAt(indexNumber);
            return todayForcast;
        }
    }
}
