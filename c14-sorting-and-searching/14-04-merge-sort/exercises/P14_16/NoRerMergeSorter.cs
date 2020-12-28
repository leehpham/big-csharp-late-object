public class NoRerMergeSorter
{
    public static void Sort(int[] a)
    {
        int length = 1;
        while (length < a.Length)
        {
            int start = 0;
            while (start + 2 * length <= a.Length)
            {
                Merge(start, start + length - 1, start + 2 * length - 1, a);
                start = start + 2 * length;
            }
            if (start + length <= a.Length)
            {
                Merge(start, start + length - 1, a.Length - 1, a);
            }
            length = length * 2;
            start = 0;
        }
    }


    private static void Merge(int from, int mid, int to, int[] a)
    {
        int n = to - from + 1;
        int[] b = new int[n];

        int i1 = from;
        int i2 = mid + 1;
        int j = 0;

        while (i1 <= mid && i2 <= to)
        {
            if (a[i1] < a[i2])
            {
                b[j] = a[i1];
                i1++;
            }
            else
            {
                b[j] = a[i2];
                i2++;
            }
            j++;
        }

        while (i1 <= mid)
        {
            b[j] = a[i1];
            i1++;
            j++;
        }
        while (i2 <= to)
        {
            b[j] = a[i2];
            i2++;
            j++;
        }
        for (j = 0; j < n; j++)
        {
            a[from + j] = b[j];
        }
    }
}