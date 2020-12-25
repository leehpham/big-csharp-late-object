public class SelectionSorter
{
    public static void Sort(int[] a)
    {
        for (int i = 0; i < a.Length - 1; i++)
        {
            int maxPos = MaximumPosition(a, i);
            ArrayUtil.Swap(a, i, maxPos);
        }
    }

    /// <summary>
    /// Gets index of maximum element from starting index to end of array.
    /// </summary>
    /// <param name="a">The array.</param>
    /// <param name="from">The starting index.</param>
    /// <returns>The index of the minimum elememt.</returns>
    private static int MaximumPosition(int[] a, int from)
    {
        int maxPos = from;
        for (int i = from; i < a.Length; i++)
        {
            if (a[i] > a[maxPos]) 
            {
                maxPos = i;
            }
        }
        return maxPos;
    }
}