using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {

            var phonebook = new SortedDictionary<string, string>();
            List<string> input = Console.ReadLine().Split(' ').ToList();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S")
                {
                    if (phonebook.ContainsKey(input[1]))
                    {
                        Console.WriteLine($"{input[1]} -> {phonebook[input[1]]}");
                    }
                    else
                    {
                        Console.WriteLine("Contact " + input[1] + " does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var contact in phonebook)
                    {
                        Console.WriteLine(contact.Key + " -> " + contact.Value);
                    }
                }

                input = Console.ReadLine().Split(' ').ToList();
            }
        }
    }
}
