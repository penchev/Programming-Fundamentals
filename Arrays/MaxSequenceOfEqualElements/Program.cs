using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[start])
                {
                    length++;
                }
                else
                {
                    start = i;
                    length = 1;
                }
                if (length > bestLength)
                {
                    bestStart = start;
                    bestLength = length;
                }
            }
            for (int i = bestStart; i < bestStart+bestLength; i++)
            {
                Console.Write(array[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}
