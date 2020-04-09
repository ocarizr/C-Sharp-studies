namespace AmazonStudies.SortAlgorithms
{
    public class BubbleSort
    {
        public int[] Solution(int[] A)
        {
            bool swaped;
            do
            {
                swaped = false;
                for (var i = 0; i < A.Length - 1; ++i)
                {
                    if (A[i] > A[i + 1])
                    {
                        (A[i], A[i + 1]) = (A[i + 1], A[i]);
                        swaped = true;
                    }
                }
            } while (swaped);

            return A;
        }
    }
}
