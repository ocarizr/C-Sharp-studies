using AmazonStudies.SortAlgorithms;
using System;
using System.Collections.Generic;

namespace AmazonStudies
{
    public class TestSortingAlgorithms
    {
        public void Start()
        {
            #region SelectionSort

            var ss = new SelectionSort();
            TestSortAlgorithm("Selection Sort - 2 Lists", ss.Solution);
            TestSortAlgorithm("Selection Sort - 1 List", ss.InPlaceSolution);

            #endregion

            #region BubbleSort

            var bs = new BubbleSort();
            TestSortAlgorithm("Bubble Sort", bs.Solution);

            #endregion

            #region InsertionSort

            var @is = new InsertionSort();
            TestSortAlgorithm("Insertion Sort", @is.Solution);

            #endregion

            #region MergeSort

            var ms = new MergeSort();
            TestSortAlgorithm("Merge Sort", ms.Solution);

            #endregion

            #region QuickSort

            var qs = new QuickSort();
            TestSortAlgorithm("QuickSort", qs.Solution);

            #endregion

            #region SwapSort

            var s = new SwapSort();
            TestSortAlgorithm("Swap Sort", s.Solution);

            #endregion
        }

        private double CalcLatency(DateTime T)
        {
            return (DateTime.Now - T).TotalMilliseconds;
        }

        private void TestSortAlgorithm(string name, Func<int[], int[]> func)
        {
            var sample = new List<int>();

            var max = 10000;

            while(max >= 0)
            {
                sample.Add(max);
                --max;
            }

            //var array = new int[] { 30, 29, 28, 27, 26, 25, 24, 23, 22, 21, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //var array = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //var result = sample.ToArray();

            Console.WriteLine(name);

            var t = DateTime.Now;
            for (int i = 0; i < 10; ++i)
            {
                //result = func(array);
                func(sample.ToArray());
            }
            var latency = CalcLatency(t);

            //foreach (var i in result) Console.Write(i + " ");
            // Console.WriteLine("- " + latency + " ms");
            Console.WriteLine(latency + " ms");
            Console.WriteLine();
        }
    }
}
