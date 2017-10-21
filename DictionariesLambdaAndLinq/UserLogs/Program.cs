using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogs
{
    class Program
    {
        static void AddIp(Dictionary<string, int> ipAddresses,string ip)
        {
            if (!ipAddresses.ContainsKey(ip))
            {
                ipAddresses.Add(ip, 1);
            }
            else
            {
                ipAddresses[ip]++;
            }
        }
        static void Main(string[] args)
        {
            var usernames = new SortedDictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputArgs = input.Split('=',' ');
                string ip = inputArgs[1];
                string username = inputArgs[5];

                if (!usernames.ContainsKey(username))
                {
                    usernames.Add(username, new Dictionary<string, int>());
                    AddIp(usernames[username], ip);
                }
                else
                {
                    AddIp(usernames[username], ip);
                }
                input = Console.ReadLine();
            }

            foreach (var user in usernames)
            {
                Console.WriteLine(user.Key + ": " );
                int i = 1;
                foreach (var ip in user.Value)
                {
                    Console.Write(ip.Key + " => " + ip.Value);
                    if (i < user.Value.Count)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                    i++;
                }
                Console.WriteLine();
            }
        }
    }
}
