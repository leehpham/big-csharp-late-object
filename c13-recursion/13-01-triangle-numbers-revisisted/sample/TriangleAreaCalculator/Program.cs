using System;

namespace TriangleAreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new Triangle(10);
            int area = t.GetArea();
            Console.WriteLine($"Area: {area}");
            Console.WriteLine("Expected: 55");
        }
    }
}
