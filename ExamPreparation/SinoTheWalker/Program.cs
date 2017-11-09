using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime leavingTime = new DateTime();
            leavingTime = DateTime.Parse(Console.ReadLine());
            int numberOfSteps = int.Parse(Console.ReadLine())% 86400;
            int timeForStep = int.Parse(Console.ReadLine()) % 86400;

            int timeForAllSteps = numberOfSteps * timeForStep;
            int minutes = 0;
            int hours = 0;

            while (timeForAllSteps > 59)
            {
                minutes++;
                timeForAllSteps-= 60;
            }

            while (minutes > 59)
            {
                hours++;
                minutes -= 60;
            }

            leavingTime += new TimeSpan(hours, minutes, timeForAllSteps);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}",leavingTime);
        }
    }
}
