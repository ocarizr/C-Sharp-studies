namespace AmazonStudies.SortAlgorithms
{
    public class MergeSort
    {
        public int[] Solution(int[] A)
        {
            if(A.Length < 2)
            {
                return A;
            }

            var nL = A.Length / 2;
            var L = new int[nL];

            var nR = A.Length - nL;
            var R = new int[nR];

            for(var i = 0; i < nL; ++i)
            {
                L[i] = A[i];
            }

            for(int i = nL, j = 0; i < A.Length; ++i, ++j)
            {
                R[j] = A[i];
            }

            L = Solution(L);
            R = Solution(R);

            return Merge(L, R, A);
        }

        private int[] Merge(int[] L, int[] R, int[] A)
        {
            var i = 0;
            var j = 0;
            var k = 0;
            while(i < L.Length && j < R.Length)
            {
                if(L[i] <= R[j])
                {
                    A[k] = L[i];
                    ++i;
                }
                else
                {
                    A[k] = R[j];
                    ++j;
                }
                ++k;
            }

            while(i < L.Length)
            {
                A[k] = L[i];
                ++i;
                ++k;
            }

            while(j < R.Length)
            {
                A[k] = R[j];
                ++j;
                ++k;
            }

            return A;
        }
    }
}
