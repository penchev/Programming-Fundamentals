using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            decimal studioPrice = 0;
            decimal doubleRoom = 0;
            decimal suite = 0;
            decimal studioStay = 0;
            decimal doubleStay = 0;
            decimal suiteStay = 0;
            int studioNights = nightCount;

            switch (month)
            {
                case "May":
                case "October":
                    if (nightCount > 7)
                    {
                        studioPrice = 50 * 0.95m;
                        if (month == "October")
                            studioNights--;
                    }
                    else studioPrice = 50;
                    doubleRoom = 65;
                    suite = 75;
                    break;
                case "June":
                case "September":
                    if (nightCount > 14)
                    {
                        doubleRoom = 72 * 0.9m;
                    }
                    else doubleRoom = 72;
                    if (nightCount > 7)
                        studioNights--;
                    studioPrice = 60;
                    suite = 82;
                    break;
                case "July":
                case "August":
                case "December":
                    if (nightCount > 14)
                    {
                        suite = 89 * 0.85m;
                    }
                    else suite = 89;
                    doubleRoom = 77;
                    studioPrice = 68;
                    break;
                default:
                    break;
            }

            studioStay = studioPrice * studioNights;
            doubleStay = doubleRoom * nightCount;
            suiteStay = suite * nightCount;

            Console.WriteLine($"Studio: {studioStay:F2} lv.");
            Console.WriteLine($"Double: {doubleStay:F2} lv.");
            Console.WriteLine($"Suite: {suiteStay:F2} lv.");
        }
    }
}