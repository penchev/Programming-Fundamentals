using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndfirstRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int k = array.Length / 4;
            Array.Reverse(array, 0, k);
            int p = 0;

            int[] firstRow = new int [array.Length / 2];
            int[] secondRow = new int[2*k];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = array[i];
                p = i;
            }
            p++;
            for (int i = array.Length - 1; i > array.Length-k-1; i--, p++)
            {
                firstRow[p] = array[i];

            }
            int j = 0;
            for (int i = k; i < array.Length-k; i++,j++)
            {
                secondRow[j] = array[i];
            }
            int[] sum = new int[2 * k];
            

            for (int i = 0; i < firstRow.Length; i++)
            {
                sum[i] = firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ", sum));

        }
    }
}
