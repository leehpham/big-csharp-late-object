/// <summary>
/// The sort method of this class sorts an array, using the selection sort algorithm.
/// </summary>
public class SelectionSorter
{
    /// <summary>
    /// Sorts an array, using selection sort.
    /// </summary>
    /// <param name="a">the array to sort</param>
    public static void Sort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            int minPos = MinimumPosition(a, i);
            ArrayUtil.Swap(a, minPos, i);
        }
    }

    /// <summary>
    /// Finds the smallest element in a tail range of the array.
    /// </summary>
    /// <param name="a">the array to sort</param>
    /// <param name="from">the first position in a to compare</param>
    /// <returns>the position of the smallest element in the range a[from] ... a[a.Length - 1]</returns>
    private static int MinimumPosition(int[] a, int from)
    {
        int minPos = from;
        for (int i = from + 1; i < a.Length; i++)
        {
            if (a[i] < a[minPos]) { minPos = i; }
        }
        return minPos;
    }
}