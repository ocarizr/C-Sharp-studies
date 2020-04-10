using System;

namespace AmazonStudies.SortAlgorithms
{
    public class QuickSort
    {
        public int[] Solution(int[] A)
        {
            Sort(ref A, 0, A.Length);
            return A;
        }

        public void Sort(ref int[] A, int begin, int end)
        {
            if (end <= begin) return;

            var pivot = Partition(ref A, begin, end);

            Sort(ref A, pivot + 1, end);
            Sort(ref A, begin, pivot);
        }

        public int Partition(ref int[] A, int begin, int end)
        {
            var pivot = end - 1;
            var pivotValue = A[pivot];
            var i = begin;

            for(var j = begin; j < pivot; ++j)
            {
                if(A[j] <= pivotValue)
                {
                    (A[j], A[i]) = (A[i], A[j]);
                    ++i;
                }
            }

            (A[pivot], A[i]) = (A[i], A[pivot]);

            return i;
        }
    }
}
