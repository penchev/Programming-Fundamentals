using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                int left = input[i];
                int rev = 0;
                int r = 0;
                while (left > 0)
                {
                    r = left % 10;
                    rev = rev * 10 + r;
                    left = left / 10;  
                }
                input[i] = rev;
                sum += input[i];
            }
            Console.WriteLine(sum);
        }
    }
}
