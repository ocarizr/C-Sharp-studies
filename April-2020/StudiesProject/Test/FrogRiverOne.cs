namespace Test
{
    class FrogRiverOne
    {
        public static int solution(int X, int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var result = 0;
            var list = new int[X];
            var found = true;
            var target = 0;
            var sum = 0;

            for (int i = 1; i <= X; ++i) target += i;

            for (; result < A.Length; ++result)
            {
                if (A[result] - 1 < X && list[A[result] - 1] == 0)
                {
                    list[A[result] - 1] = 1;
                    sum += A[result];
                }
                found = sum == target;
                if (found) break;
            }

            return found ? result : -1;
        }
    }
}
