using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int counter = 0;
            int totalSum = 0;
            int multiply = 0;
            while (N >= 1)
            {
                for (int i = 1; i <= M; i++)
                {
                    if (totalSum < maxSum)
                    {
                        multiply = 3 * (N * i);
                        totalSum += multiply;
                        counter++;
                    }
                    else break;
                }
                N--;
            }
            Console.WriteLine($"{counter} combinations");
            if (totalSum >= maxSum)
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            else
                Console.WriteLine($"Sum: {totalSum}");
        }
    }
}