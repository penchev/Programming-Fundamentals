using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int buffer = 0;

            if (firstNumber > secondNumber)
            {
                buffer = firstNumber;
                firstNumber = secondNumber;
                secondNumber = buffer;
            }
            for (int i = firstNumber; i <= secondNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}