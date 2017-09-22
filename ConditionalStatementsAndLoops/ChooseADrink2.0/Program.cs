using System;

namespace ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            string perfectDrink = string.Empty;
            int quantity = int.Parse(Console.ReadLine());
            double bill = 0;

            switch (profession)
            {
                case "Athlete":
                    perfectDrink = "Water";
                    bill = quantity * 0.7;
                    break;
                case "Businessman":
                case "Businesswoman":
                    perfectDrink = "Coffee";
                    bill = quantity * 1;
                    break;
                case "SoftUni Student":
                    perfectDrink = "Beer";
                    bill = quantity * 1.7;
                    break;
                default:
                    perfectDrink = "Tea";
                    bill = quantity * 1.2;
                    break;

            }

            Console.WriteLine($"The {profession} has to pay {bill:F2}.");
        }
    }
}