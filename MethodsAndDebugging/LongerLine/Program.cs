using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongerLine
{
    class Program
    {
        static void CloserToCenter(double x1, double y1, double x2, double y2)
        {
            double xCloser = 0;
            double yCloser = 0;
            double buffer1 = 0;
            double buffer2 = 0;
            double xFar = 0;
            double yFar = 0;


            buffer1 = Math.Abs(x1) + Math.Abs(y1);
            buffer2 = Math.Abs(x2) + Math.Abs(y2);
            if (buffer1 > buffer2)
            {
                xCloser = x2;
                xFar = x1;
                yCloser = y2;
                yFar = y1;
            }
            else 
            {
                xCloser = x1;
                yCloser = y1;
                yFar = y2;
                xFar = x2;
            }
            


            Console.WriteLine($"({xCloser}, {yCloser})({xFar}, {yFar})");
        }
        static void LongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
        {
            {
                double x1Bigger = 0;
                double y1Bigger = 0;
                double x2Bigger = 0;
                double y2Bigger = 0;
                double buffer1 = 0;
                double buffer2 = 0;



                buffer1 = Math.Abs(x1) + Math.Abs(y1) + Math.Abs(x2) + Math.Abs(y2);
                buffer2 = Math.Abs(x3) + Math.Abs(y3) + Math.Abs(x4) + Math.Abs(y4);
                if (buffer1 > buffer2)
                {
                    x1Bigger = x1;
                    y1Bigger = y1;
                    x2Bigger = x2;
                    y2Bigger = y2;
                }
                else
                {
                    x1Bigger = x3;
                    y1Bigger = y3;
                    x2Bigger = x4;
                    y2Bigger = y4;
                }
                CloserToCenter(x1Bigger, y1Bigger, x2Bigger, y2Bigger);
            }
        }
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongerLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }
    }
}

