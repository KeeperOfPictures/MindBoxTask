using System;

namespace MindBoxTask
{
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
                throw new Exception("Сторона треугольника меньше или равна 0.");
            A = a;
            B = b;
            C = c;
        }

        public bool IsRight()
        {
            var sides = new[] { A, B, C };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }

        public override double GetArea()
        {
            double s = (A + B + C) / 2;
            var square = Math.Sqrt(s * (s - A) * (s - B) * (s - C));
            return square;
        }
    }
}
