using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            int timeToFilter = int.Parse(Console.ReadLine());
            short filterFactor = short.Parse(Console.ReadLine());
            int timeForUploadingOnePic = int.Parse(Console.ReadLine());
            double filterFactorInPercent = (double)filterFactor / 100;
            double filteredPictures = Math.Ceiling(numberOfPictures * filterFactorInPercent);
            long timeForFiltering = numberOfPictures * timeToFilter;
            long timeForUpload = timeForUploadingOnePic * (int)filteredPictures;
            long timeNeeded = timeForFiltering + timeForUpload;
            long seconds = timeNeeded;
            long minutes = seconds/60;
            long hours = minutes/60;
            long days = hours/24;

            TimeSpan time = TimeSpan.FromSeconds(timeNeeded);
            Console.WriteLine("{0:D1}:{1:D2}:{2:D2}:{3:D2}", time.Days, time.Hours, time.Minutes, time.Seconds);
        }
    }
}