using System;

namespace P14_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Coin[] arr = ArrayUtil.CreateCoinArr(10);
            Console.WriteLine(ArrayUtil.ToString(arr));

            SelectionSorter.Sort(arr);
            Console.WriteLine(ArrayUtil.ToString(arr));
        }
    }
}
