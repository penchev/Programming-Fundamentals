using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialTrailingZeros
{

    class Program
    {
        static BigInteger Factorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }

        static void TrailingZeros(BigInteger factorial)
        {
            int zeros = 0;
            while (factorial > 0)
            {
                BigInteger digit = factorial % 10;
                factorial = factorial / 10;
                if (digit == 0)
                {
                    zeros++;
                }
                else break;
            }
            Console.WriteLine(zeros);
        }
        static void Main(string[] args)
        {
            
            BigInteger factorial = Factorial(int.Parse(Console.ReadLine()));
            TrailingZeros(factorial);
        }
    }
}
