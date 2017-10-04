using System;

namespace VariableInHexFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberInHexa = Console.ReadLine();
            int numberInDecimal = Convert.ToInt32(numberInHexa, 16);

            Console.WriteLine(numberInDecimal);
        }
    }
}