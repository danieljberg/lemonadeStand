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
        public int numberWillingToBuy;
        public Weather Weather;
        public List<Customer> dayCustomerList;
        Random randomNumber;

        //construstor
        public Day(Player player, Random random)
        {
            Weather = new Weather(random);
            dayCustomerList = new List<Customer>();            
            randomNumber = random;
            numberWillingToBuy = 0;
            GenerateCustomerBase(Weather, player, random);
            howManyWillBuy(dayCustomerList);
        }
        

        //member methods(HAS TO)
        public void howManyWillBuy(List<Customer> dayCustomerList)
        {
            for (int i = 0; i < dayCustomerList.Count; i++)
            {
                if (dayCustomerList[i].willBuy == true)
                {
                    numberWillingToBuy++;
                }
            }

        }
        public void GenerateCustomerBase(Weather weather, Player player, Random random)
        {
            if (weather.actualDayTemperature >= 90)
            {
                int randomNumberOfCustomers = randomNumber.Next(80, 120);
                for (int i = 0; i < randomNumberOfCustomers; i++)
                {
                    Customer customer = new Customer(Weather, player.Recipe, random);
                    dayCustomerList.Add(customer);
                }
            }
            if (weather.actualDayTemperature >= 70 && weather.actualDayTemperature < 90)
            {
                int randomNumberOfCustomers = randomNumber.Next(70, 100);
                for (int i = 0; i < randomNumberOfCustomers; i++)
                {
                    Customer customer = new Customer(Weather, player.Recipe, random);
                    dayCustomerList.Add(customer);
                }
            }
            if (weather.actualDayTemperature < 70)
            {
                int randomNumberOfCustomers = randomNumber.Next(60, 80);
                for (int i = 0; i < randomNumberOfCustomers; i++)
                {
                    Customer customer = new Customer(Weather, player.Recipe, random);
                    dayCustomerList.Add(customer);
                }
            }
        }               
    }
}
