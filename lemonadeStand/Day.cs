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
        public Weather Weather;
        public Recipe Recipe;
        public List<Customer> dayCustomerList;

        //construstor
        public Day()
        {
            Weather = new Weather();
            Recipe = new Recipe();
            dayCustomerList = new List<Customer>();
        }
        

        //member methods(HAS TO)
        public void GenerateCustomerBase(Weather weather)
        {
            if (weather.actualDayTemperature >= 90)
            {
                Random randomNumber = new Random();
                int randomNumberOfCustomers = randomNumber.Next(80, 120);
                for (int i = 0; i < randomNumberOfCustomers; i++)
                {
                    Customer customer = new Customer(Weather, Recipe);
                    dayCustomerList.Add(customer);
                }
            }
            if (weather.actualDayTemperature >= 70 && weather.actualDayTemperature < 90)
            {
                Random randomNumber = new Random();
                int randomNumberOfCustomers = randomNumber.Next(70, 100);
                for (int i = 0; i < randomNumberOfCustomers; i++)
                {
                    Customer customer = new Customer(Weather, Recipe);
                    dayCustomerList.Add(customer);
                }
            }
            if (weather.actualDayTemperature < 70)
            {
                Random randomNumber = new Random();
                int randomNumberOfCustomers = randomNumber.Next(60, 80);
                for (int i = 0; i < randomNumberOfCustomers; i++)
                {
                    Customer customer = new Customer(Weather, Recipe);
                    dayCustomerList.Add(customer);
                }
            }
        }               
    }
}
