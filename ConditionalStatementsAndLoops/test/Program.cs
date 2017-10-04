using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            try
            {
                while (n <= 20)
                {
                    string input = Console.ReadLine();
                    if (input == "Bake!")
                    {
                        Console.WriteLine($"Preparing cake with {n} ingredients.");
                        break;
                    }
                    n++;
                    Console.WriteLine($"Adding ingredient {input}.");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Bake!");
            }
        }
    }
}