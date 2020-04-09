using AmazonStudies.SearchAlgorithms;
using System;
using System.Collections.Generic;

namespace AmazonStudies
{
    public class TestSearchAlgorithms
    {
        public void Start()
        {
            #region LinearSearch

            var ls = new LinearSearch();
            TestAlgorithm("Linear Search", ls.Solution);

            #endregion

            #region BinarySearch

            var bs = new BinarySearch();
            TestAlgorithm("Binary Search", bs.Solution);
            CalcLatency("Binary FindFirst", bs.FindFirst, new int[] { 0, 1, 1, 2, 3, 4, 5, 5, 5, 5, 5, 6, 6, 7, 8, 9 }, 5);
            CalcLatency("Binary FindLast", bs.FindLast, new int[] { 0, 1, 1, 2, 3, 4, 5, 5, 5, 5, 5, 6, 6, 7, 8, 9 }, 5);
            CalcLatency("Binary CountOcurrences", bs.CountRepetitions, new int[] { 0, 1, 1, 2, 3, 4, 5, 5, 5, 5, 5, 6, 6, 7, 8, 9 }, 5);

            #endregion

            #region JumpSearch

            var js = new JumpSearch();
            TestAlgorithm("Jump Search", js.Solution);

            #endregion

            #region InterpolationSearch

            var @is = new InterpolationSearch();
            TestAlgorithm("Interpolation Search", @is.Solution);

            #endregion
        }

        public void CalcLatency(string name, Func<int[], int, int> func, int[] array, int target)
        {
            Console.WriteLine(name);
            var result = -1;
            var t = DateTime.Now;
            for (int i = 0; i < 1000000; ++i)
            {
                result = func(array, target);
            }
            var latency = (DateTime.Now - t).TotalMilliseconds;

            Console.WriteLine(result + " - " + latency + " ms");
            Console.WriteLine();
        }

        private void TestAlgorithm(string name, Func<int[], int, int> func)
        {
            var sample = new List<int>();

            var max = 0;

            while (max < 100000)
            {
                sample.Add(max);
                ++max;
            }

            var target = 67597;
            var result = -1;

            Console.WriteLine(name);

            var t = DateTime.Now;
            for (int i = 0; i < 100; ++i)
            {
                result = func(sample.ToArray(), target);
            }
            var latency = (DateTime.Now - t).TotalMilliseconds;

            Console.WriteLine(result + " - " + latency + " ms");
            Console.WriteLine();
        }
    }
}
