using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class Customer
    {
        //member variables(HAS A)
        public bool toBuy;
        public int chanceToBuy;
        public double priceWillingToPay;

        //construstor
        public Customer()
        {
            priceWillingToPay = .25;
        }


        //member methods(HAS TO)
        public void GeneratePriceWillingToPay()
        {
            Random randomNumber = new Random();
            double adjustPriceWillingToPay = randomNumber.NextDouble();
            priceWillingToPay += adjustPriceWillingToPay;
        }
        public void PriceWillingToPay(Day today)
        {
            if (today.Weather.actualDayTemperature >= 90)
            {
                priceWillingToPay += .75;
            }
            else if (today.Weather.actualDayTemperature >= 80 && today.Weather.actualDayTemperature < 90)
            {
                priceWillingToPay += .25;
            }
            else if (today.Weather.actualDayTemperature >= 60 && today.Weather.actualDayTemperature < 70)
            {
                priceWillingToPay -= .25;
            }
        }
        public bool ChanceToBuy(Day today)
        {
            Random randomNumber = new Random();
            chanceToBuy = randomNumber.Next(101);
            switch (today.Weather.actualDayForecast)
            {
                case "Sunny":
                    if (chanceToBuy >= 10)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }                    
                case "Partly Sunny":
                    if (chanceToBuy >= 20)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "Partly Cloudy":
                    if (chanceToBuy >= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "Overcast":
                    if (chanceToBuy >= 40)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "Rainy":
                    if (chanceToBuy >= 50)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return false;
            }            
        }
    }
}
