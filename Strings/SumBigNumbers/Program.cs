using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            int length = Math.Min(firstNumber.Length, secondNumber.Length);

            if (firstNumber.Length > secondNumber.Length) {
                secondNumber = secondNumber.PadLeft(firstNumber.Length, '0');
            }
            else
            {
                firstNumber = firstNumber.PadLeft(secondNumber.Length, '0');
            }

            int reminder = 0;
            int sum = 0;
            int number = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = firstNumber.Length-1; i >=0; i--)
            {
                sum = firstNumber[i] -48 + secondNumber[i] - 48+reminder;
                number = sum % 10;
                reminder = sum / 10;
                sb.Append(number);

                if (i==0 && reminder>0)
                {
                    sb.Append(reminder);
                }
            }
            Console.WriteLine(sb.ToString().ToCharArray().Reverse().ToArray());
        }
    }
}
