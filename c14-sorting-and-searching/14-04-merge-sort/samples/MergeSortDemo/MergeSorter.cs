/// <summary>
/// The sort method of this class sorts an array, using the merge sort algorithm.
/// </summary>
public class MergeSorter
{
    public static void Sort(int[] a)
    {
        if (a.Length <= 1) { return; }
        int[] first = new int[a.Length / 2];
        int[] second = new int[a.Length - first.Length];
        // Copy the first half of a into first, the second half into second
        for (int i = 0; i < first.Length; i++)
        {
            first[i] = a[i];
        }
        for (int i = 0; i < second.Length; i++)
        {
            second[i] = a[first.Length + i];
        }
        Sort(first);
        Sort(second);
        Merge(first, second, a);
    }


    private static void Merge(int[] first, int[] second, int[] a)
    {
        int iFirst = 0; // Next element to consider in the first array
        int iSecond = 0; // Next element to consider in the second array
        int j = 0; // Next open position in a

        // As long as neither iFirst or iSecond past the end, move
        // the smallest element into a
        while (iFirst < first.Length && iSecond < second.Length)
        {
            if (first[iFirst] < second[iSecond])
            {
                a[j] = first[iFirst];
                iFirst++;
            }
            else
            {
                a[j] = second[iSecond];
                iSecond++;
            }
            j++;
        }

        // Note that only one of the two loops below copies entries
        // Copy any remaining entries of the first array
        while (iFirst < first.Length)
        {
            a[j] = first[iFirst];
            iFirst++;
            j++;
        }

        // Copy any remaining entries of the second half
        while(iSecond < second.Length)
        {
            a[j] = second[iSecond];
            iSecond++;
            j++;
        }
    }
}