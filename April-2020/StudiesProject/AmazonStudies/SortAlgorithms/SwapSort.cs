namespace AmazonStudies.SortAlgorithms
{
    public class SwapSort
    {
        public int[] Solution(int[] A)
        {
            for(int i = 0; i < A.Length; ++i)
            {
                while (i != A[i])
                {
                    (A[i], A[A[i]]) = (A[A[i]], A[i]);
                }
            }

            return A;
        }
    }
}
