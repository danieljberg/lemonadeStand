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
        public int projectedDayTemperature;
        public string projectedDayForecast;
        public List<string> weatherForecastList;
        

        //construstor
        public Weather()
        {
            weatherForecastList = new List<string>() { "Sunny", "Partly Sunny", "Partly Cloudy", "Overcast", "Rainy" };
            projectedDayTemperature = GetTempature();
            projectedDayForecast = GetForecast(weatherForecastList);
        } 

        //member methods(HAS TO)
        public int GetTempature()
        {
            Random randomTemp = new Random();
            projectedDayTemperature = randomTemp.Next(60, 103);
            return projectedDayTemperature;
        }
        public string GetForecast(List<string> weatherForecast)
        {
            Random randomNumber = new Random();
            int indexNumber = randomNumber.Next(5);
            projectedDayForecast = weatherForecast.ElementAt(indexNumber);
            return projectedDayForecast;
        }
            //public void GetWeekTempature(int daysPlaying)
            //{
            //    for (int i = 0; i < daysPlaying; i++)
            //    {
            //        temperature = GetTempature();
            //        weekTemperature.Add(temperature);                
            //    }
            //    weekTemperature.ForEach(Console.WriteLine);
            
            //}
    }
}
