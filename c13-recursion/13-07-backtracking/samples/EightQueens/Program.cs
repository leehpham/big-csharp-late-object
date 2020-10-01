using System;

namespace EightQueens
{
    /// <summary>
    /// This class solves the eight queens problem using backtracking.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solve(new PartialSolution(0));
        }

        public static void Solve(PartialSolution sol)
        {
            int exam = sol.Examine();
            if (exam == PartialSolution.ACCEPT)
            {
                Console.WriteLine(sol);
            }
            else if (exam != PartialSolution.ABANDON)
            {
                foreach (PartialSolution p in sol.Extend())
                {
                    Solve(p);
                }
            }
        }
    }
}
