using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            bool[] primes = new bool[n+1];

            for (int i = 0; i < primes.Length; i++)
            {
                primes[i] = true;
            }
            primes[0] = primes[1] = false;

            for (int i = 0; i < primes.Length; i++)
            {

                if (primes[i] == true)
                {
                    Console.Write(i);
                    Console.Write(" ");
                    for (int p = 2; p * i < primes.Length; p++)
                        primes[i * p] = false;
                }

            }
        }
    }
}
