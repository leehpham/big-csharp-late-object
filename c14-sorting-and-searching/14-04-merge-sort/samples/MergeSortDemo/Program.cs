using System;

namespace MergeSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = ArrayUtil.RandomIntArray(20, 100);
            Console.WriteLine(ArrayUtil.ToString(a));

            MergeSorter.Sort(a);
            Console.WriteLine(ArrayUtil.ToString(a));
        }
    }
}
