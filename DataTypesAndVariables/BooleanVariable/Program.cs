using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            if (Convert.ToBoolean(value))
                Console.WriteLine("Yes");
            else Console.WriteLine("No");
        }
    }
}