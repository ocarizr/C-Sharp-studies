using System.Collections.Generic;
using System.Linq;

namespace AmazonStudies.SortAlgorithms
{
    public class SelectionSort
    {
        public int[] Solution(int[] A)
        {
            var a = A.ToList();
            var res = new List<int>();
            var iMin = 0;

            while (a.Count > 0)
            {
                var min = int.MaxValue;

                for (var i = 0; i < a.Count; ++i)
                {
                    if (a[i] < min)
                    {
                        min = a[i];
                        iMin = i;
                    }
                }
                res.Add(min);
                a.RemoveAt(iMin);
            }

            return res.ToArray();
        }

        public int[] InPlaceSolution(int[] A)
        {
            for (int i = 0; i < A.Length - 1; ++i)
            {
                int iMin = i;

                for (int j = i + 1; j < A.Length; ++j)
                {
                    if (A[j] < A[iMin]) iMin = j;
                }

                var temp = A[i];
                A[i] = A[iMin];
                A[iMin] = temp;
            }

            return A;
        }
    }
}
