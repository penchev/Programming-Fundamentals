using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicalNumber = int.Parse(Console.ReadLine());
            int magicNum1 = 0;
            int magicNum2 = 0;
            int counter = 0;

            for (int i = N; i <= M; i++)
            {
                for (int j = N; j <= M; j++)
                {
                    if ((i + j) == magicalNumber)
                    {
                        magicNum1 = i;
                        magicNum2 = j;
                    }
                    counter++;
                }
            }
            if (magicNum1 != 0 && magicNum2 != 0)
                Console.WriteLine($"Number found! {magicNum1} + {magicNum2} = {magicalNumber}");
            else
                Console.WriteLine($"{counter} combinations - neither equals {magicalNumber}");
        }
    }
}