using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterPoing
{
    class Program
    {
        static void CloserToCenter(double x1, double y1, double x2, double y2)
        {
            double xCloser = 0;
           double yCloser = 0;
            double buffer1 = 0;
            double buffer2 = 0;

            

            buffer1 = Math.Abs(x1) + Math.Abs(y1);
            buffer2 = Math.Abs(x2) + Math.Abs(y2);
            if (buffer1 > buffer2)
            {
                xCloser = x2;
                yCloser = y2;
            }
            else
            {
                xCloser = x1;
                yCloser = y1;
            }
                

            Console.WriteLine($"({xCloser}, {yCloser})");
        }
        static void Main(string[] args)
        {
            CloserToCenter(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
        }
    }
}
