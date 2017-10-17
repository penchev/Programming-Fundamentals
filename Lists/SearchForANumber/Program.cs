using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchForANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int [] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool contains = false;

            for (int i = 0; i < array[1]; i++)
            {
                input.RemoveAt(0);
            }

            for (int i = 0; i < input.Count; i++)
            {
                if (array[2] == input[i])
                {
                    contains = true;
                    break;
                }
            }
            if(contains)
                Console.WriteLine("YES!");
            else
                Console.WriteLine("NO!");
        }
    }
}
