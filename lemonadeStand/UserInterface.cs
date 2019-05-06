using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lemonadeStand
{
    class UserInterface
    {
        //member variables(HAS A)


        //construstor


        //member methods(HAS TO)
        public string GetName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        public int HowMany(string itemToCount)
        {
            Console.WriteLine($"How many {itemToCount} do you want");
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
        public void DisplayInventory(int numberOfCups, int numberOfLemons, int cupsOfSugar, int numberOfIceCubes)
        {
            Console.WriteLine($"INVENTORY:\n\nCups: {numberOfCups}\nLemons: {numberOfLemons}\nSugar(cups): {cupsOfSugar}\nIce cubes: {numberOfIceCubes}");
        }
        public void DisplayRecipe(int howManyLemons, int howMuchSugar, int howManyIceCubes)
        {
            Console.WriteLine($"RECIPE:\n\nLemons: {howManyLemons}\nSugar: {howMuchSugar}\nIce: {howManyIceCubes}");
        }
        public void DisplayWeather(int todayTempature, string todayForcast)
        {
            Console.WriteLine($"Today's Tempature: {todayTempature}°F\nToday's Forcast: {todayForcast}");
        }
    }
}
