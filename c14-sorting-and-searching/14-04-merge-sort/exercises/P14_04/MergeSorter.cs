using System;

public class MergeSorter
{
    public static void Sort(string[] a)
    {
        if (a.Length <= 1) { return; }
        string[] first = new string[a.Length / 2];
        string[] second = new string[a.Length - first.Length];
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

    private static void Merge(string[] first, string[] second, string[] a)
    {
        int iFirst = 0;
        int iSecond = 0;
        int j = 0;

        while (iFirst < first.Length && iSecond < second.Length)
        {
            if (String.Compare(first[iFirst], second[iSecond]) < 0)
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

        while (iFirst < first.Length)
        {
            a[j] = first[iFirst];
            iFirst++;
            j++;
        }

        while (iSecond < second.Length)
        {
            a[j] = second[iSecond];
            iSecond++;
            j++;
        }
    }
}