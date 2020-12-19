using System;

/// <summary>
/// A queen in the eight queens problem.
/// </summary>
public class Queen
{
    private int row;
    private int column;

    /// <summary>
    /// Constructs a queen at a given position.
    /// </summary>
    /// <param name="r">the row</param>
    /// <param name="c">the column</param>
    public Queen(int r, int c)
    {
        row = r;
        column = c;
    }

    /// <summary>
    /// Checks whether this queen attacks another.
    /// </summary>
    /// <param name="other">The other queen.</param>
    /// <returns>true if this and the other queen are in the same row, column, or diagonal.</returns>
    public bool Attacks(Queen other)
    {
        return row == other.row
            || column == other.column
            || Math.Abs(row - other.row) == Math.Abs(column - other.column);
    }

    public override string ToString()
    {
        return "" + "abcdefgh"[column] + (row + 1);
    }
}