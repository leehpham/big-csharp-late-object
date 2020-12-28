using System;

public class ArrayUtil
{
    private static Random rand = new Random();

    public static int[] RandomIntArray(int size, int limit)
    {
        int[] a = new int[size];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rand.Next(limit + 1);
        }
        return a;
    }

    public static string ToString(int[] a)
    {
        string output = "";
        foreach (int ele in a)
        {   
            output += ele + " ";
        }
        return output;
    }
}