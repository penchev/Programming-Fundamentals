using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertFromBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();
            long decimalNumber = long.Parse(input[1]);
            long n = long.Parse(input[0]);
            string number = "";
            while (decimalNumber > 0)
            {
                long rem = decimalNumber % n;
                number += rem;
                decimalNumber /= n;
            }
            string reversed = "";
            for (int i = number.Length - 1, j = 0; i >= 0; i--, j++)
            {
                reversed += number[i];
            }

            Console.WriteLine(reversed);
        }
    }
}





