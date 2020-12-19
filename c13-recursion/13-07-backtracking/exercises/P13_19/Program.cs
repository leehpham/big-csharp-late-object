using System;

namespace P13_19
{
    /// <summary>
    /// This class solves the eight queens problem using backtracking.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solve(new EightQueenPartialSolution(0));
        }

        public static void Solve(EightQueenPartialSolution sol)
        {
            int exam = sol.Examine();
            if (exam == EightQueenPartialSolution.ACCEPT)
            {
                Console.WriteLine(sol);
            }
            else if (exam != EightQueenPartialSolution.ABANDON)
            {
                foreach (EightQueenPartialSolution p in sol.Extend())
                {
                    Solve(p);
                }
            }
        }
    }
}
