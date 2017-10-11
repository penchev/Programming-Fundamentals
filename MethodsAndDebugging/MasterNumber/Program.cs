using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterNumber
{
    class Program
    {
        static bool IsPalindrome(int num)
        {
            string number = num.ToString();

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == number[number.Length - 1-i])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        static bool SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                sum = sum + digit;
            }

            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool ContainsEvenDigit(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());

            for (int i = 1; i < endNum; i++)
            {
                if(IsPalindrome(i) && ContainsEvenDigit(i) && SumOfDigits(i))
                {
                    Console.WriteLine(i);
                }
               
            }
         
        }
    }
}
