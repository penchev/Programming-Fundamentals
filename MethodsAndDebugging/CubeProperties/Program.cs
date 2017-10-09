using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class Program
    {
        static double FaceOfCube(double side)
        {
            double face = Math.Sqrt(2*Math.Pow(side,2));
            return face;
        }

        static double SpaceOfCube(double side)
        {
            double space = Math.Sqrt(3 * Math.Pow(side, 2));
            return space;
        }

        static double VolumeOfCube(double side)
        {
            double volume = Math.Pow(side, 3);
            return volume;
        }

        static double AreaOfCube(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            return area;
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "face":
                    double face = FaceOfCube(side);
                    Console.WriteLine($"{face:f2}");
                    break;
                case "space":
                    double space = SpaceOfCube(side);
                    Console.WriteLine($"{space:f2}");
                    break;
                case "volume":
                    double volume = VolumeOfCube(side);
                    Console.WriteLine($"{volume:f2}");
                    break;
                case "area":
                    double area = AreaOfCube(side);
                    Console.WriteLine($"{area:f2}");
                    break;

            }
        }
    }
}
