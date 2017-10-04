using System;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = Console.ReadLine();
            string secondWord = Console.ReadLine();
            var wordsTogether = firstWord + " " + secondWord;
            Console.WriteLine(wordsTogether);
        }
    }
}