namespace AmazonStudies.SearchAlgorithms
{
    public class InterpolationSearch
    {
        public int Solution(int[] A, int S)
        {
            var iMin = 0;
            var iMax = A.Length - 1;

            while(iMax > iMin && A[iMin] <= S && A[iMax] >= S)
            {
                if(iMax == iMin)
                {
                    if (A[iMin] == S) return iMin;
                    return -1;
                }

                int pos = iMin + (iMax - iMin) / (A[iMax] - A[iMin]) * (S - A[iMin]);

                if (A[pos] == S) return pos;

                if (A[pos] < S) iMin = pos;
                else iMax = pos;
            }

            return -1;
        }
    }
}
