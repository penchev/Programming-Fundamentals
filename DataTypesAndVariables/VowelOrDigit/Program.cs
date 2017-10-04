using System;

namespace VowelOrDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            char symbol = char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'o' || symbol == 'e' || symbol == 'u' || symbol == 'y' || symbol == 'i')
                Console.WriteLine("vowel");
            else if (symbol >= '0' && symbol <= '9')
                Console.WriteLine("digit");
            else Console.WriteLine("other");
        }
    }
}