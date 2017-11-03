using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicExchangableWords
{
    class Program
    {
        static bool isExchangeable(char[] str1, char[] str2)
        {
            if (str1.Length == str2.Length)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var arrayOne = input[0].ToCharArray().Distinct().ToArray();
            var arrayTwo = input[1].ToCharArray().Distinct().ToArray();

            bool exchangeable = isExchangeable(arrayOne, arrayTwo);
            if (exchangeable)
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}
