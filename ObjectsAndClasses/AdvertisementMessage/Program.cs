﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();

          

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int phraseIndex = rnd.Next(0, phrases.Length);
                int eventsIndex = rnd.Next(0, events.Length);
                int authorsIndex = rnd.Next(0, authors.Length);
                int citiesIndex = rnd.Next(0, cities.Length);
                Console.WriteLine("{0} {1} {2} - {3}", phrases[phraseIndex],events[eventsIndex],authors[authorsIndex],cities[citiesIndex]);
            }
        }
    }
}
