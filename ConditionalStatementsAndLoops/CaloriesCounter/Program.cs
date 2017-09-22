using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            int cheese = 500;
            int tomatoSauce = 150;
            int salami = 600;
            int pepper = 50;
            string ingredient = string.Empty;
            int calories = 0;

            for (int i = 0; i <numberOfIngredients; i++)
            {
                ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese":
                        calories += cheese;
                        break;
                    case "tomato sauce":
                        calories += tomatoSauce;
                        break;
                    case "salami":
                        calories += salami;
                        break;
                    case "pepper":
                        calories += pepper;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {calories}");
        }
    }
}