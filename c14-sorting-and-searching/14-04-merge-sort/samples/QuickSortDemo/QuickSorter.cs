public class QuickSorter
{
    public static void Sort(int[] a, int from, int to)
    {
        if (from >= to) { return; }
        int p = Partition(a, from, to);
        Sort(a, from, p);
        Sort(a, p + 1, to);
    }

    private static int Partition(int[] a, int from, int to)
    {
        int pivot = a[from];
        int i = from - 1;
        int j = to + 1;
        while (i < j)
        {
            i++;
            while (a[i] < pivot) { i++; }
            j--;
            while (a[j] > pivot) { j--; }
            if (i < j) { ArrayUtil.Swap(a, i, j); }
        }
        return j;
    }
}