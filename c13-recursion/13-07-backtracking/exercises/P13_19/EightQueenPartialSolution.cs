using System.Linq;

public class EightQueenPartialSolution : IPartialSolution
{
    private Queen[] queens;
    private const int NQUEENS = 8;

    public const int ACCEPT = 1;
    public const int ABANDON = 2;
    public const int CONTINUE = 3;

    public EightQueenPartialSolution(int size)
    {
        queens = new Queen[size];
    }

    public int Examine()
    {
        for (int i = 0; i < queens.Length; i++)
        {
            for (int j = i + 1; j < queens.Length; j++)
            {
                if (queens[i].Attacks(queens[j])) { return ABANDON; }
            }
        }
        if (queens.Length == NQUEENS) { return ACCEPT; }
        else { return CONTINUE; }
    }

    public EightQueenPartialSolution[] Extend()
    {
        // Generate a new solution for each column.
        EightQueenPartialSolution[] result = new EightQueenPartialSolution[NQUEENS];
        for (int i = 0; i < result.Length; i++)
        {
            int size = queens.Length;

            // The new solution has one more queen (on the next higher row) than this one.
            result[i] = new EightQueenPartialSolution(size + 1);

            // Copy this solution into the new one.
            for (int j = 0; j < size; j++)
            {
                result[i].queens[j] = queens[j];
            }

            // Append the new queen into the ith column.
            result[i].queens[size] = new Queen(size, i);
        }
        return result;
    }

    public override string ToString()
    {
        return string.Join(",", queens.Select(q => q.ToString()).ToArray());
    }
}