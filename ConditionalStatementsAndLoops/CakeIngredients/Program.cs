using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = string.Empty;
            int number = 0;
            while ((ingredient= Console.ReadLine()) != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredient}.");
                number++;
            } 
            Console.WriteLine($"Preparing cake with {number} ingredients.");
        }
    }
}