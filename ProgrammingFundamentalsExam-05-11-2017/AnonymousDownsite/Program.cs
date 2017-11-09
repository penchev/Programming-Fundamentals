using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDownsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWebsites = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal sum = 0;
            List<string> siteNames = new List<string>();
            for (int i = 0; i < numberOfWebsites; i++)
            {
                var input = Console.ReadLine().Split(' ');
                string siteName = input[0];
                decimal siteCommercialPricePerVisit = 0;
                uint siteVisits = 0;
                siteNames.Add(siteName);
                siteVisits = uint.Parse(input[1]);
                siteCommercialPricePerVisit = decimal.Parse(input[2]);
                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                sum += siteLoss;
            }
            foreach (var site in siteNames)
            {
                Console.WriteLine(site);
            }
            string securityToken = (Math.Pow(securityKey,numberOfWebsites)).ToString();
            Console.WriteLine($"Total Loss: {sum:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
