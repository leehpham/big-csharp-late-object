public class InsertionSorter
{
    public static void Sort(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {   
            int next = a[i];
            // Move all larger elements up
            int j = i;
            while (j > 0 && a[j - 1] > next)
            {
                a[j] = a[j - 1];
                j--;
            }
            // Insert the element
            a[j] = next;
        }
    }
}