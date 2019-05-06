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
        public Weather todaysWeather;

        //construstor
        todaysWeather = new Weather();

        //member methods(HAS TO)
        public void GenerateCustomerBase()
        {

        }
        public void GetTheWeather()
        {

        }
        public void GetTheRecipe()
        {

        }
    }
}
