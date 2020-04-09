namespace AmazonStudies.SearchAlgorithms
{
    public class LinearSearch
    {
        public int Solution(int[] A, int S)
        {
            var res = -1;

            for(var i = 0; i < A.Length; ++i)
            {
                if (A[i] == S)
                {
                    res = i;
                    break;
                }
            }

            return res;
        }
    }
}
