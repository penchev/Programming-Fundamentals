using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            foreach (char s in input)
            {
                Console.Write(@"\u{0:x4}", (int)s);
            }
            Console.WriteLine();
        }
    }
}
