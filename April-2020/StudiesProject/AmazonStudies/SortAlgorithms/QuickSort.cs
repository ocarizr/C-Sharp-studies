namespace AmazonStudies.SortAlgorithms
{
    public class QuickSort
    {
        public int[] Solution(int[] A)
        {
            return Quicksort(ref A, 0, A.Length);
        }

        private int[] Quicksort(ref int[] A, int iStart, int iEnd)
        {
            if(iEnd - iStart == 1)
            {
                return A;
            }

            var pivot = Partition(ref A, iStart, iEnd);

            if (pivot > iStart)
                Quicksort(ref A, iStart, pivot);
            else if (pivot < iEnd - 1)
                Quicksort(ref A, pivot, iEnd);

            return A;
        }

        private int Partition(ref int[] A, int iStart, int iEnd)
        {
            var value = A[iEnd - 1];
            var pivot = iEnd - 1;

            for(; iStart < iEnd - 1; ++iStart)
            {
                if(A[iStart] > value)
                {
                    (A[iStart], A[pivot]) = (A[pivot], A[iStart]);
                    pivot = iStart;
                }
            }

            return pivot;
        }
    }
}
