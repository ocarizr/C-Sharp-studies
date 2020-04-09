using System.Collections.Generic;

namespace Test
{
    class OddOccurrencesInArray
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var result = 0;

            var numbers = new Dictionary<int, int>();

            foreach (var i in A)
            {
                if (numbers.ContainsKey(i)) ++numbers[i];
                else numbers.Add(i, 1);
            }

            foreach (var i in numbers)
            {
                if (i.Value % 2 == 1)
                {
                    result = i.Key;
                    break;
                }
            }

            return result;
        }
    }
}
