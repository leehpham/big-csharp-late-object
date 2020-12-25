using System;

public class ArrayUtil
{
    private static Random rand = new Random();

    public static int[] RandomIntArray(int size, int limit)
    {
        int[] arr = new int[size];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(limit + 1);
        }
        return arr;
    }

    public static string ToString(int[] arr)
    {
        string output = "";
        foreach (int element in arr)
        {
            output += element + " ";
        }
        return output;
    }
}