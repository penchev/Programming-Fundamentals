using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void AddCityAndPopulation(Dictionary<string, long> cities,string city, long population)
        {
            if (!cities.ContainsKey(city))
            {
                cities.Add(city, population);
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] inputArgs = input.Split('|');
                string country = inputArgs[1];
                string city = inputArgs[0];
                int population = int.Parse(inputArgs[2]);

                if (!countries.ContainsKey(country))
                {
                    countries.Add(country, new Dictionary<string, long>());
                    AddCityAndPopulation(countries[country],city, population);
                }
                else
                {
                    AddCityAndPopulation(countries[country], city, population);
                }
                input = Console.ReadLine();

            }
            foreach (var country in countries.OrderByDescending(x=> x.Value.Values.Sum()))
            {
                Console.WriteLine(country.Key + " (total population: " + country.Value.Values.Sum() + ")");
                foreach (var city in country.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("=>" + city.Key + ": " + city.Value);
                }
            }
        }
    }
}
