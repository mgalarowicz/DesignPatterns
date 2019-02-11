using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factories
{
    class InnerFactory
    {
    }
    /*
    public class Point
    {
        private double x, y;

        private Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"{nameof(x)}: {x}, {nameof(y)}: {y}";
        }

        public static Point Origin => new Point(0,0);  //Property (it's combination of methods) - every time when I try to access Point.Origin I will be getting a new Point with (0,0).

        public static Point Origin2 = new Point(0,0); //Field - get's initialize static filed once and that field is available to use everywhere - BETTER APPROACH

        // Factory is a separate component which knows how to initialize types in a particular way
        public class Factory
        {
            public static Point NewCartesianPoint(double x, double y)
            {
                return new Point(x, y);
            }

            public static Point NewPolarPoint(double rho, double theta)
            {
                return new Point(rho*Math.Cos(theta), rho*Math.Sin(theta));
            }
        }
    }

    public class Demo
    {
        static void Main(string[] args)
        {
            var point = Point.Factory.NewPolarPoint(1.0, Math.PI/2);
            Console.WriteLine(point);

            var origin = Point.Origin;
        }
    }
    */
}
