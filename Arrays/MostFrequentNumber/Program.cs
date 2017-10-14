using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int frequentNumber = array[0];
            int frequency = 1;
            int bestFrequent = 0;
            int bestFrequency = 1;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        frequency++;
                        frequentNumber = array[i];
                    }
               
                    if (frequency > bestFrequency)
                    {
                        bestFrequent = frequentNumber;
                        bestFrequency = frequency;
                    }
                }
                frequency = 1;
            }


            Console.WriteLine(bestFrequent);
        }
    }
}
