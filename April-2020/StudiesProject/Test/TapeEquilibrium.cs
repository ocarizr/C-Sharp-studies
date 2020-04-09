using System;

namespace Test
{
    class TapeEquilibrium
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var result = int.MaxValue;

            var sum = 0;

            foreach (var i in A) sum += i;

            var sum1 = 0;

            for (int i = 0; i < A.Length - 1; ++i)
            {
                sum1 += A[i];
                sum -= A[i];

                var temp = Math.Abs(sum1 - sum);

                if (temp < result) result = temp;
                if (result == 0) break;
            }

            return result;
        }
    }
}