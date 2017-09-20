using System;

namespace BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energyPer100ml = double.Parse(Console.ReadLine());
            double sugarPer100ml = double.Parse(Console.ReadLine());

            double energyPerOneMl = energyPer100ml / 100;
            double energy = energyPerOneMl * volume;
            double sugarPer1ml = sugarPer100ml / 100;
            double sugar = sugarPer1ml * volume;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}