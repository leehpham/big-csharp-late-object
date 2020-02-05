using System;

namespace P13_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Square(100)).GetArea());
            Console.WriteLine((new Square(1)).GetArea());
            Console.WriteLine((new Square(0)).GetArea());
        }
    }
}
