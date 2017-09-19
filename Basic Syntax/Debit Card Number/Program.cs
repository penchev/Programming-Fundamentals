using System;

namespace Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int firstInteger = int.Parse(Console.ReadLine());
            int secondInteger = int.Parse(Console.ReadLine());
            int thirdInteger = int.Parse(Console.ReadLine());
            int fourthInteger = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstInteger:D4} {secondInteger:D4} {thirdInteger:D4} {fourthInteger:D4}");
        }
    }
}