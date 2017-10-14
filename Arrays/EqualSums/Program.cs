using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sumOnLeft = 0;
            int sumOnRight = 0;
            bool found = false;

            for (int i = 0; i < array.Length; i++)
            {
                if (i < array.Length - 1)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        sumOnRight += array[j];
                    }
                }else
                {
                    sumOnRight = 0;
                }
                if (i > 0)
                {
                    for (int k = i - 1; k >= 0; k--)
                    {
                        sumOnLeft += array[k];
                    }
                }
                else
                {
                    sumOnLeft = 0;
                }
                if (sumOnLeft == sumOnRight)
                {
                    Console.WriteLine(i);
                    found = true;
                }
                sumOnLeft = 0;
                sumOnRight = 0;
            }
            if (!found)
            {
                Console.WriteLine("no");
            }
        }
    }
}
