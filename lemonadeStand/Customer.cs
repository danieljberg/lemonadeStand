using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    public class Customer
    {
        //member variables(HAS A)
        public bool willBuy;
        public bool chanceToBuy;
        public double priceWillingToPay;
        Random randomNumber;

        //construstor
        public Customer(Weather weather, Recipe recipe, Random random)
        {
            randomNumber = random;
            priceWillingToPay = GeneratePriceWillingToPay();
            AdjustPriceWillingToPay(weather);
            chanceToBuy = ChanceToBuy(weather);
            willBuy = WillBuy(recipe);
        }

        //member methods(HAS TO)
        public bool WillBuy(Recipe recipe)
        {
            if (recipe.pricePerCup <= priceWillingToPay && chanceToBuy == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double GeneratePriceWillingToPay()
        {
            double randomPrice = randomNumber.NextDouble() + .25;
            return randomPrice;
        }
        public void AdjustPriceWillingToPay(Weather weather)
        {
            if (weather.actualDayTemperature >= 90)
            {
                priceWillingToPay += .75;
            }
            else if (weather.actualDayTemperature >= 80 && weather.actualDayTemperature < 90)
            {
                priceWillingToPay += .25;
            }
            else if (weather.actualDayTemperature >= 60 && weather.actualDayTemperature < 70)
            {
                priceWillingToPay -= .25;
            }
        }
        public bool ChanceToBuy(Weather weather)
        {
            int chanceToBuyNumber = randomNumber.Next(101);
            switch (weather.actualDayForecast)
            {
                case "Sunny":
                    if (chanceToBuyNumber >= 10)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }                    
                case "Partly Sunny":
                    if (chanceToBuyNumber >= 20)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "Partly Cloudy":
                    if (chanceToBuyNumber >= 30)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "Overcast":
                    if (chanceToBuyNumber >= 40)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case "Rainy":
                    if (chanceToBuyNumber >= 50)
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
