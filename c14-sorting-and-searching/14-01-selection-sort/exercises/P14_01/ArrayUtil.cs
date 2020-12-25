using System;

public class ArrayUtil
{
    private static Random rand = new Random();

    public static int[] CreateRandomArray(int length, int limit)
    {
        int[] a = new int[length];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rand.Next(limit + 1);
        }
        return a;
    }

    /// <summary>
    /// Swaps 2 elements of array.
    /// </summary>
    /// <param name="a">The array.</param>
    /// <param name="i">The first element.</param>
    /// <param name="j">The second element</param>
    public static void Swap(int[] a, int i, int j)
    {
        int temp = a[i];
        a[i] = a[j];
        a[j] = temp;
    }

    public static string ToString(int[] a)
    {
        string output = "";
        foreach (int element in a)
        {
            output += element + " ";
        }
        return output;
    }
}