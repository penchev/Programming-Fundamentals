using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doubleersectionOfCycles
{
    class Program
    {
        static bool doubleersect(Circle c1, Circle c2)
        {
            double d = Math.Sqrt(Math.Pow((c2.Center.X - c1.Center.X),2)+ Math.Pow((c2.Center.Y - c1.Center.Y),2));
            if (d <= (c1.Radius + c2.Radius))
            {
                return true;
            }
            else
                return false;
        }
        static void Main(string[] args)
        {
            Circle firstCircle = new Circle();
            string input = Console.ReadLine();
            string[] inputArg = input.Split(' ');
            double x = double.Parse(inputArg[0]);
            double y = double.Parse(inputArg[1]);
            firstCircle.Center = new Podouble { X = x, Y = y };
            firstCircle.Radius = double.Parse(inputArg[2]);

            Circle secondCircle = new Circle();
            input = Console.ReadLine();
            inputArg = input.Split(' ');
            x = double.Parse(inputArg[0]);
            y = double.Parse(inputArg[1]);
            secondCircle.Center = new Podouble { X = x, Y = y };
            secondCircle.Radius = double.Parse(inputArg[2]);

            if (doubleersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        public class Circle
        {
            public Podouble Center = new Podouble();

            public double Radius { get; set; }
        }

        public class Podouble
        {
            public double X { get; set; }
            public double Y { get; set; }

        }
    }
}
