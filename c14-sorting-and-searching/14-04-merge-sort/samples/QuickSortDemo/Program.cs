using System;

namespace QuickSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {13, 88, 37, 44, 69, 74, 59, 23};
            QuickSorter.Sort(a, 0, a.Length - 1);

            foreach (int element in a)
            {
                Console.Write(element + " ");
            }
        }
    }
}
