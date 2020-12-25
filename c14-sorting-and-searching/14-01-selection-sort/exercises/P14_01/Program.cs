using System;

namespace P14_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = ArrayUtil.CreateRandomArray(20, 100);
            Console.WriteLine(ArrayUtil.ToString(a));

            SelectionSorter.Sort(a);
            Console.WriteLine(ArrayUtil.ToString(a));
        }
    }
}
