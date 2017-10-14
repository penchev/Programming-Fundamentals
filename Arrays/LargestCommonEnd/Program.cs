using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int arrOneLength = arr1.Length;
            int arrTwoLength = arr2.Length;
            int length = 0;
            int counterFromLeft = 0;
            int counterFromRight = 0;
            int difference = 0;
            bool first = false;

            if (arrOneLength > arrTwoLength)
            {
                length = arrTwoLength;
                difference = arrOneLength - arrTwoLength-1;
                first = true;
            }
            else
            {
                length = arrOneLength;
                difference = arrTwoLength - arrOneLength-1;
            }

            for (int i = 0; i < length; i++)
            {
                if (arr1[i] == arr2[i])
                    counterFromLeft++;
                else break;
            }

            for (int i = length; i >0; i--)
            {
                if (first)
                {
                    if (arr1[i + difference] == arr2[i-1])
                        counterFromRight++;
                }
                else
                {
                    if (arr1[i-1] == arr2[i+difference])
                        counterFromRight++;
                }
            }

            if (counterFromLeft > counterFromRight)
                Console.WriteLine(counterFromLeft);
            else Console.WriteLine(counterFromRight);
        }
    }
}
