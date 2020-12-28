using System;

namespace P14_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = ArrayUtil.RandomIntArray(20, 100);
            Console.WriteLine(ArrayUtil.ToString(a));

            NoRerMergeSorter.Sort(a);
            Console.WriteLine(ArrayUtil.ToString(a));
        }
    }
}
