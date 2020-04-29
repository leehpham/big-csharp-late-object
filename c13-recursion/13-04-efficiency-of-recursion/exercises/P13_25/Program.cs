using System;

namespace P13_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            var n = Convert.ToInt32(Console.ReadLine());
            long[] savedFibVals = new long[n + 1];
            savedFibVals[0] = 0;
            savedFibVals[1] = 1;
            savedFibVals[2] = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"f({i}) = {Fib(i, savedFibVals)}");
            }
        }

        public static long Fib(int n, long[] savedFibVals)
        {
            if (n == 0) return 0;
            if (n == 1 || n == 2) return 1;

            long old;
            if (savedFibVals[n - 1] == 0) savedFibVals[n - 1] = Fib(n - 1, savedFibVals);
            old = savedFibVals[n - 1];

            long older;
            if (savedFibVals[n - 2] == 0) savedFibVals[n - 2] = Fib(n - 2, savedFibVals);
            older = savedFibVals[n - 2];
            
            return old + older;
        }
    }
}
