using System;

namespace Test
{
    class CyclicRotation
    {
        public static int[] solution(int[] A, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (K == 0 || A.Length == 0 || K % A.Length == 0) return A;

            var ex = K % A.Length;
            var temp = new int[ex];

            for (int i = A.Length - 1, j = ex - 1; j >= 0; --i, --j)
            {
                temp[j] = A[i];
            }

            for (int i = A.Length - 1; i >= ex; --i)
            {
                A[i] = A[i - ex];
            }

            for (int i = 0; i < ex; ++i)
            {
                A[i] = temp[i];
            }

            return A;
        }
    }
}
