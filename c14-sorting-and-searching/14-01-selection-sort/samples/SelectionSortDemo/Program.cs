using System;

namespace SelectionSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = ArrayUtil.RandomIntArray(20, 100);
            Console.WriteLine(ArrayUtil.ToString(a));

            SelectionSorter.Sort(a);

            Console.WriteLine(ArrayUtil.ToString(a));
        }
    }
}
