using System;

namespace InsertionSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {11, 9, 16, 5, 7};
            InsertionSorter.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
