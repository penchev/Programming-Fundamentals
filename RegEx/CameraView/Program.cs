using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int[] numbersToTake = input.Split(' ').Select(int.Parse).ToArray();

            var text = Console.ReadLine().ToCharArray();
            char[] fortmattedText = text.Skip(numbersToTake[0]).Take(numbersToTake[1]).ToArray();
        }
    }
}
