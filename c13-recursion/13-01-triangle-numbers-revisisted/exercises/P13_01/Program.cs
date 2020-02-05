using System;

namespace P13_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((new Rectangle(3, 2)).GetArea());
            Console.WriteLine((new Rectangle(0, 2)).GetArea());
            Console.WriteLine((new Rectangle(3, 0)).GetArea());
            Console.WriteLine((new Rectangle(1, 10)).GetArea());
        }
    }
}
