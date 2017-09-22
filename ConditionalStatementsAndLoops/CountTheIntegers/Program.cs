using System;

namespace CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            var input = string.Empty;
            int buffer = 0;
            bool flag = false;
            do
            {
                if (flag)
                    counter++;
                input = Console.ReadLine();
                flag = true;
            } while (int.TryParse(input, out buffer));

            Console.WriteLine(counter);
        }
    }
}