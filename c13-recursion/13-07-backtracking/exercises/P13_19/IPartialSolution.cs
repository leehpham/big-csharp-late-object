interface IPartialSolution
{
    /// <summary>
    /// Examines a partial solution.
    /// </summary>
    /// <returns>one of ACCEPT, ABANDON, CONTINUE.</returns>
    int Examine();

    /// <summary>
    /// Yields all extensions of this partial solution.
    /// </summary>
    /// <returns>An array of partial solutions that extend this solution.</returns>
    EightQueenPartialSolution[] Extend();
}