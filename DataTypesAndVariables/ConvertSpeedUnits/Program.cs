using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            short hours = short.Parse(Console.ReadLine());
            short minutes = short.Parse(Console.ReadLine());
            short seconds = short.Parse(Console.ReadLine());

            int hoursInSeconds = hours * 3600;
            int minutesInSeconds = minutes * 60;
            int secondsSum = hoursInSeconds + minutesInSeconds + seconds;
            float metersPerSecond = (float)distance/secondsSum;

            float minutesInHours = (float)minutes / 60;
            float secondsInHours = (float)seconds / 3600;
            float hoursSum = hours + minutesInHours + secondsInHours;
            float kmPerHour = distance / (hoursSum*1000);
            float milePerHour = distance / (hoursSum * 1609);

            Console.WriteLine($"{metersPerSecond}");
            Console.WriteLine($"{kmPerHour}");
            Console.WriteLine($"{milePerHour}");
        }
    }
}