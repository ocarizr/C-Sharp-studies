using System.Collections.Generic;

namespace Test
{
    class MissingInteger
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var result = 1;
            var distinct = new HashSet<int>();

            foreach (var a in A) if (a > 0) distinct.Add(a);

            while (distinct.Contains(result))
            {
                ++result;
            }

            return result;
        }
    }
}
