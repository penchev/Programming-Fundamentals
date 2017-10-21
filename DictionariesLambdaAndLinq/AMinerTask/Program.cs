using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var resources = new Dictionary<string, long>();

            while (input != "stop")
            {
                long quantity = long.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    resources[input] = 0;
                }
                resources[input] += quantity;
                input = Console.ReadLine();
            }
            foreach (var resource in resources)
            {
                Console.WriteLine(resource.Key + " -> " + resource.Value);
            }
        }
    }
}
