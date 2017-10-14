using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int buffer = 0;
            int[] rotated1 = new int[num.Length];
            int[] rotated2 = new int[num.Length];
            int[] sum = new int[num.Length];

            for (int j = 0; j < k; j++)
            {
                buffer = num[num.Length - 1];
                for (int i = num.Length - 1; i > 0; i--)
                {
                    num[i] = num[i - 1];

                }
                num[0] = buffer;
                for (int i = 0; i < num.Length; i++)
                {
                    sum[i] += num[i];
                }

            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
