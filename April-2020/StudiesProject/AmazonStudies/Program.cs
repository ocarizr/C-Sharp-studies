using AmazonStudies.SortAlgorithms;
using System;

namespace AmazonStudies
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting Algorithms");
            var testSortings = new TestSortingAlgorithms();
            testSortings.Start();

            Console.WriteLine("Search Algorithms");
            var testSearch = new TestSearchAlgorithms();
            testSearch.Start();
        }
    }
}
