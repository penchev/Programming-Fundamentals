using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        static void TriangleArea(double side, double height)
        {
            double area = side * height / 2;
            Console.WriteLine($"{area:f2}");

        }

        static void SquareArea(double side)
        {
            Console.WriteLine($"{side * side:f2}");

        }

        static void RectangleArea(double width, double height)
        {
            Console.WriteLine($"{width * height:f2}");
        }

        static void CircleArea(double radius)
        {
            Console.WriteLine($"{Math.PI * radius * radius:f2}");
        }
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    TriangleArea(side, height);
                    break;
                case "square":
                    side = double.Parse(Console.ReadLine());
                    SquareArea(side);
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    height = double.Parse(Console.ReadLine());
                    RectangleArea(width, height);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    CircleArea(radius);
                    break;
                default:
                    break;
            }
        }
    }
}
