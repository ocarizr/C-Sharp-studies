namespace AmazonStudies.SortAlgorithms
{
    public class InsertionSort
    {
        public int[] Solution(int[] A)
        {
            for(var i = 1; i < A.Length; ++i)
            {
                var value = A[i];
                var hole = i;
                while(hole > 0 && A[hole - 1] > value)
                {
                    A[hole] = A[hole - 1];
                    hole = hole - 1;
                }
                A[hole] = value;
            }
            return A;
        }
    }
}
