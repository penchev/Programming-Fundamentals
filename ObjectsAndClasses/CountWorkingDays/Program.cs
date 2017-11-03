using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStartDate = Console.ReadLine();
            string inputEndDate = Console.ReadLine();
            DateTime startDate = DateTime.ParseExact(inputStartDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(inputEndDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int workingDaysCounter = 0;
            List<DateTime> officialHolidays = new List<DateTime>();
            DateTime newYearEve = DateTime.ParseExact("01-01", "dd-MM", CultureInfo.InvariantCulture);
            DateTime liberationDay = DateTime.ParseExact("03-03", "dd-MM", CultureInfo.InvariantCulture);
            DateTime workersDay = DateTime.ParseExact("01-05", "dd-MM", CultureInfo.InvariantCulture);
            DateTime saintGeorgesDay = DateTime.ParseExact("06-05", "dd-MM", CultureInfo.InvariantCulture);
            DateTime saintCyrilAndMethodius = DateTime.ParseExact("24-05", "dd-MM", CultureInfo.InvariantCulture);
            DateTime unificationDay = DateTime.ParseExact("06-09", "dd-MM", CultureInfo.InvariantCulture);
            DateTime independenceDay = DateTime.ParseExact("22-09", "dd-MM", CultureInfo.InvariantCulture);
            DateTime nationalAwakeningDay = DateTime.ParseExact("01-10", "dd-MM", CultureInfo.InvariantCulture);
            DateTime christmasFirst = DateTime.ParseExact("24-12", "dd-MM", CultureInfo.InvariantCulture);
            DateTime christmasSecond = DateTime.ParseExact("25-12", "dd-MM", CultureInfo.InvariantCulture);
            DateTime christmasThird = DateTime.ParseExact("26-12", "dd-MM", CultureInfo.InvariantCulture);
            bool officialHoliday = false;

            officialHolidays.Add(newYearEve);
            officialHolidays.Add(liberationDay);
            officialHolidays.Add(workersDay);
            officialHolidays.Add(saintGeorgesDay);
            officialHolidays.Add(saintCyrilAndMethodius);
            officialHolidays.Add(unificationDay);
            officialHolidays.Add(independenceDay);
            officialHolidays.Add(nationalAwakeningDay);
            officialHolidays.Add(christmasFirst);
            officialHolidays.Add(christmasSecond);
            officialHolidays.Add(christmasThird);

            for (var day = startDate.Date; day <= endDate.Date; day = day.AddDays(1))
            {


                if (day.DayOfWeek == DayOfWeek.Saturday || day.DayOfWeek == DayOfWeek.Sunday)
                {
                    //count++;
                }
                else if (officialHolidays.Any(x => x.Day == day.Day && x.Month == day.Month))
                {
                    //count++;
                }
                else
                {
                    workingDaysCounter++;
                }

            }
            Console.WriteLine(workingDaysCounter);
        }

    }
}

