using MindBoxTask;
using System;

namespace MindBoxTask
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            if (radius <= 0) throw new Exception("Радиус меньеш или равен 0.");
            Radius = radius;
        }
        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
