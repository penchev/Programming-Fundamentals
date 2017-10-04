using System;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double eps = 0.000001;

            double result = Math.Abs(firstNumber - secondNumber);
            if(result>=eps)
                Console.WriteLine("False");
            else Console.WriteLine("True");
        }
    }
}