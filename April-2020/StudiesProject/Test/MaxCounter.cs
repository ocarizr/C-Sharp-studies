using System;

namespace Test
{
    class MaxCounter
    {
        public static int[] solution(int N, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var result = new int[N];
            var cur = 0;
            var maxCounter = 0;

            for (var i = 0; i < A.Length; ++i)
            {
                var index = A[i] - 1;

                if (A[i] <= N && A[i] > 0)
                {
                    result[index] = Math.Max(cur, result[index]) + 1;
                    maxCounter = Math.Max(maxCounter, result[index]);
                }
                else if (A[i] == N + 1)
                {
                    cur = maxCounter;
                }
            }

            for (var i = 0; i < N; ++i)
            {
                result[i] = Math.Max(result[i], cur);
            }

            return result;
        }
    }
}
