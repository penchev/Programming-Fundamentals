using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = new char[26];
            char[] input = Console.ReadLine().ToArray();
            int j = 0;

            for (char i = 'a'; i <='z'; i++,j++)
            {
                letters[j] = i;
            }

            for (int i = 0; i < input.Length; i++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    if (input[i] == letters[k])
                    {
                        Console.WriteLine($"{input[i]} -> {k}");
                    }
                }
            }
        }
    }
}
