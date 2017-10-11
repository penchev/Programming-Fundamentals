using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Factorial(int num)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <=num; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(factorial);
        }
        static void Main(string[] args)
        {
            Factorial(int.Parse(Console.ReadLine()));
        }
    }
}
