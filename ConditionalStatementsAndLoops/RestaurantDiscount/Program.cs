using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal hallPrice = 0;
            decimal packagePrice = 0;
            decimal totalPrice = 0;
            decimal pricePerPerson = 0;
            string Hall = string.Empty;
            decimal discount = 0;
            bool toContinue = true;

            if (groupSize > 0 && groupSize <= 50)
            {
                hallPrice = 2500;
                Hall = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                hallPrice = 5000;
                Hall = "Terrace";
            }
            else if (groupSize <= 120)
            {
                hallPrice = 7500;
                Hall = "Great Hall";
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                toContinue = false;
            }

            if (toContinue)
            {
                switch (package)
                {
                    case "Normal":
                        packagePrice = 500;
                        discount = 5;
                        break;
                    case "Gold":
                        packagePrice = 750;
                        discount = 10;
                        break;
                    case "Platinum":
                        packagePrice = 1000;
                        discount = 15;
                        break;
                    default:
                        break;
                }
                totalPrice = hallPrice + packagePrice;
                discount = (discount / 100) * totalPrice;
                totalPrice = totalPrice - discount;
                pricePerPerson = totalPrice / groupSize;

                Console.WriteLine($"We can offer you the {Hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}