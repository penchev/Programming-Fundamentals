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
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 1; i <list.Count; i++)
            {
                if (list[i] == list[start])
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

            if(bestLength==1)
                Console.WriteLine(list[0]);
            else
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(list[i]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
    }

