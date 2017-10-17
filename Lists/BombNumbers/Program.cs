using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] detonate = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < input.Count; i++)
            {
                if (detonate[0] == input[i])
                {
                    for (int j = 0; j < detonate[1] && i+1<input.Count; j++)
                    {
                        input.RemoveAt(i+1);
                    }
                    for (int j =detonate[1]; j >0 && i-1>=0; j--)
                    {
                        input.RemoveAt(i-1);
                        i--;
                    }
                    input.RemoveAt(i);
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                sum += input[i];
            }
            Console.WriteLine(sum);
        }
    }
}
