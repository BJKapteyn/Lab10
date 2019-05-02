using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double GetCircumference(double radius)
        {
            double cRadius = 2 * Math.PI * radius;
            return cRadius;
        }

        public double GetArea(double radius)
        {
            double cArea = Math.PI * Math.Pow((radius), 2);
            return cArea;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The radius of this circle is {_radius}" +
                $"\nThe Circumference is {Math.Round(GetCircumference(_radius), 2)}" +
                $"\nThe Area is {Math.Round(GetArea(_radius), 2)}\n\n");
        }
    }
}
