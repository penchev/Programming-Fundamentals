using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        static void AddDragon(SortedDictionary<string, int[]> drake, string name, int[] stats)
        {
            drake[name] = stats;
        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, int[]>> dragons = new Dictionary<string, SortedDictionary<string, int[]>>();


            for (int i = 0; i < number; i++)
            {
                var input = Console.ReadLine();
                string[] inputArgs = input.Split(' ').ToArray();
                string type = inputArgs[0];
                string name = inputArgs[1];

                if (inputArgs[2] == "null")
                {
                    inputArgs[2] = "45";
                }
                if (inputArgs[3] == "null")
                {
                    inputArgs[3] = "250";
                }
                if (inputArgs[4] == "null")
                {
                    inputArgs[4] = "10";
                }
                int[] stats = new int[] {
                    int.Parse(inputArgs[2]), int.Parse(inputArgs[3]),int.Parse(inputArgs[4])};


                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, int[]>());
                    AddDragon(dragons[type], name, stats);
                }
                else
                {
                    AddDragon(dragons[type], name, stats);
                }
            }
            
            foreach (var type in dragons)
            {
                double averageDmg = 0;
                double averageHealth = 0;
                double averageArmor = 0;
                int counter = 0;
                foreach (var stat in type.Value)
                {
                    averageDmg += stat.Value.First();
                    averageHealth += stat.Value.Skip(1).First();
                    averageArmor += stat.Value.Last();
                    counter++;
                }
                averageDmg /= counter;
                averageArmor /= counter;
                averageHealth /= counter;

                Console.WriteLine(type.Key + "::({0:f2}/{1:f2}/{2:f2})", averageDmg,averageHealth,averageArmor);
                foreach (var name in type.Value)
                {
                    Console.WriteLine("-" + name.Key + " -> damage: " + name.Value.First() +
                        ", health: " + name.Value.Skip(1).First() + ", armor: " + name.Value.Last());
                }
            }
        }
    }
}
