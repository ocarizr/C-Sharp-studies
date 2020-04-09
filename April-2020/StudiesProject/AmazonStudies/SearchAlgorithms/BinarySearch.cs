namespace AmazonStudies.SearchAlgorithms
{
    public class BinarySearch
    {
        public int Solution(int[] A, int S)
        {
            int max = A.Length - 1;
            int min = 0;

            while (max >= min)
            {
                int mid = min + (max - min) / 2;

                if (A[mid] == S)
                {
                    return mid;
                }
                else if (A[mid] > S)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return -1;
        }

        public int FindFirst(int[] A, int S)
        {
            var result = -1;
            int max = A.Length - 1;
            int min = 0;

            while (max >= min)
            {
                int mid = min + (max - min) / 2;

                if (A[mid] == S)
                {
                    result = mid;
                    max = mid - 1;
                }
                else if (A[mid] > S)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return result;
        }

        public int FindLast(int[] A, int S)
        {
            var result = -1;
            int max = A.Length - 1;
            int min = 0;

            while (max >= min)
            {
                int mid = min + (max - min) / 2;

                if (A[mid] == S)
                {
                    result = mid;
                    min = mid + 1;
                }
                else if (A[mid] > S)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }

            return result;
        }

        public int CountRepetitions(int[] A, int S)
        {
            var first = FindFirst(A, S);
            var last = FindLast(A, S);

            if (last == -1 || first == -1) return 0;

            return last - first + 1;
        }
    }
}
