using System;

namespace LoopFib
{
    /// <summary>
    /// This program computes Fibonacci numbers using an iterative method.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                long f = Fib(i);
                Console.WriteLine($"fib({i}) = {f}");
            }
        }

        public static long Fib(int n)
        {
            if (n <= 2) { return 1; }
            else
            {
                long olderValue = 1;
                long oldValue = 1;
                long newValue = 1;
                for (int i = 3; i <= n; i++)
                {
                    newValue = oldValue + olderValue;
                    olderValue = oldValue;
                    oldValue = newValue;
                }
                return newValue;
            }
        }
    }
}
