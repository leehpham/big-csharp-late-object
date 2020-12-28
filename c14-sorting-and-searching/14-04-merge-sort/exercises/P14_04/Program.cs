using System;

namespace P14_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] a = 
            {
                "6yDFoN9Eec",
                "cNGS3t5PuT",
                "ViEc6b0rT6",
                "ELvifiBiqM",
                "NLG2dU7oCt"
            };

            MergeSorter.Sort(a);

            foreach (string element in a)
            {
                Console.WriteLine(element);
            }
        }
    }
}
