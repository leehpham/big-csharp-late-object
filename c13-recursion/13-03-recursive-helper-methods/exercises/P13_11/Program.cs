using System;

namespace P13_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareRoot(100));
        }

        public static double SquareRoot(double x)
        {
            return SquareRootGuess(x, 3);
        }

        public static double SquareRootGuess(double x, double g)
        {
            if (g * g == x) return g;
            else
            {
                return SquareRootGuess(x, (g + x / g) / 2);
            }
        }
    }
}
