using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void ReversedNumber(string number)
        {
            string reversedNumber = string.Empty;
            while (number.Length>0)
            {
                reversedNumber = reversedNumber + number.Substring(number.Length-1);
                number = number.Remove(number.Length - 1);
                
            }
            Console.WriteLine(reversedNumber);
        }
        static void Main(string[] args)
        {
            ReversedNumber(Console.ReadLine());
        }
    }
}
