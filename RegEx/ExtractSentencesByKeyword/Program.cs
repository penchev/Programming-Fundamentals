using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var input = Console.ReadLine();
            var sentences = input.Split(new char[] { '.', '!', '?' }).ToArray();
            string pattern = "\\b" + word + "\\b";
            foreach (var sentence in sentences)
            {
                if(Regex.IsMatch(sentence,pattern))
                Console.WriteLine(sentence.Trim(' '));
            }
        }
    }
}
