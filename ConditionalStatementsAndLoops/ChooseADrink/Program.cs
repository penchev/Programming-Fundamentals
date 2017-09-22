using System;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string perfectDrink = string.Empty;

            switch (profession)
            {
                case "Athlete":
                    perfectDrink = "Water";
                    break;
                case "Businessman":
                case "Businesswoman":
                    perfectDrink = "Coffee";
                    break;
                case "SoftUni Student":
                    perfectDrink = "Beer";
                    break;
                default:
                    perfectDrink = "Tea";
                    break;

            }

            Console.WriteLine(perfectDrink);
        }
    }
}