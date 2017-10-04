using System;

namespace CenturiesToNanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = short.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)Math.Floor(years * 365.2422);
            int hours = days * 24;
            long minutes = hours * 60;
            long seconds = minutes * 60;
            ulong milliSeconds = (ulong)seconds * 1000;
            ulong microSeconds = milliSeconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = " +
                $"{hours} hours = {minutes} minutes = {seconds} seconds = {milliSeconds} milliseconds = " +
                $"{microSeconds} microseconds = {microSeconds}000 nanoseconds");

        }
    }
}