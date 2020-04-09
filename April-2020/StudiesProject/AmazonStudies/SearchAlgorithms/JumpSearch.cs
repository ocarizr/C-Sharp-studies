using System;

namespace AmazonStudies.SearchAlgorithms
{
    public class JumpSearch
    {
        public int Solution(int[] A, int S)
        {
            var step = (int)Math.Sqrt(A.Length);
            var prev = 0;
            var i = 0;
            while(A[Math.Min(i, A.Length - 1)] < S)
            {
                prev = i;
                i += step;
                if (prev >= A.Length) return -1;
            }

            while(A[prev] < S)
            {
                ++prev;
                if (prev == Math.Min(i, A.Length)) return -1;
            }

            return A[prev] == S ? prev : -1;
        }
    }
}
