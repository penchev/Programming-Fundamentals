using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterMultiplier
{
    class Program
    {
        static int CharMultiplier(string str1, string str2)
        {
            int sum = 0;
            int biggerStringLength = 0;
            int smallerStringLength = 0;
            bool firstIsBigger = false;

            if (str1.Length > str2.Length)
            {
                smallerStringLength = str2.Length;
                biggerStringLength = str1.Length;
                firstIsBigger = true;
            }
            else
            {
                biggerStringLength = str2.Length;
                smallerStringLength = str1.Length;
            }
            for (int i = 0; i < smallerStringLength; i++)
            {
                sum += str1[i] * str2[i];
            }
            if (smallerStringLength != biggerStringLength)
            {
                for (int i = smallerStringLength; i < biggerStringLength; i++)
                {
                    if (firstIsBigger)
                    {
                        sum += str1[i];
                    }
                    else
                    {
                        sum += str2[i];
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = CharMultiplier(input[0], input[1]);
            Console.WriteLine(sum);
        }
    }
}
