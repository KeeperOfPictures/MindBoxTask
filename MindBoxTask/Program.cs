using System;

namespace MindBoxTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(5);
            Console.WriteLine(circle.GetArea());
            var triangle = new Triangle(3, 4, 5);
            Console.WriteLine(triangle.GetArea());
            Console.WriteLine(triangle.IsRight());

            /*
            SELECT
                p.ProductName, 
                c.CategoryName
            FROM Products p
            LEFT JOIN ProductCategories pc ON p.ProductID = pc.ProductID
            LEFT JOIN Categories c ON pc.CategoryID = c.CategoryID;
            */
        }
    }
}
