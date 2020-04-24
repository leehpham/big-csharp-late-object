using System;

namespace RecursiveFibTracer
{
    /// <summary>
    /// This program prints trace messages that show how often
    /// the recursive method for computing Fibonacci numbers calls itself.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            long f = Fib(n);

            Console.WriteLine($"fib({n}) = {f}");
        }

        /// <summary>
        /// Computes a Fibonacci number.
        /// </summary>
        /// <param name="n">An integer.</param>
        /// <returns>The nth Fibonaci number.</returns>
        public static long Fib(int n)
        {
            Console.WriteLine($"Entering fib: n = {n}");
            long f;
            if (n <= 2) { f = 1; }
            else { f = Fib(n - 1) + Fib(n - 2); }
            Console.WriteLine($"Exiting fib: n = {n} return value = {f}");
            return f;
        }
    }
}
