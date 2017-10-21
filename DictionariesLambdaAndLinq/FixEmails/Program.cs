using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = Console.ReadLine();
            var emailBook = new Dictionary<string, string>();

            while (person != "stop")
            {
                string email = Console.ReadLine();
                if (!email.Contains(".us") && !email.Contains(".uk"))
                    emailBook[person] = email;

                person = Console.ReadLine();
            }
            foreach (var email in emailBook)
            {
                Console.WriteLine(email.Key + " -> " + email.Value);
            }
        }
    }
}
