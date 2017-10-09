using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class Program
    {
        static double Fib(int number)
        {
            number = number + 1;
            double Phi = Math.Pow(1.6180339, number);
            double phi = Math.Pow(-0.6180339, number);
            double fibNumber = Math.Ceiling(((Phi - phi) / 2.236067977));
                return fibNumber;
            
        }
        static void Main(string[] args)
        {
            double fibNumber = Fib(int.Parse(Console.ReadLine()));
            Console.WriteLine(fibNumber);
        }
    }
}
