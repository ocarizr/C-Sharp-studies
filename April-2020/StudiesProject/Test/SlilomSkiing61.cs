using System;
using System.Collections.Generic;

namespace Test
{
    class SlilomSkiing61
    {
        public static int GreaterSubSeq(List<int> sequence)
        {
            var smallest_value = new int[sequence.Count + 1];
            smallest_value[0] = -1;

            var longestSubSeq = 0;

            for (var i = 0; i < sequence.Count; ++i)
            {
                var lowerValue = 0;
                var upperValue = longestSubSeq;

                while (lowerValue <= upperValue)
                {
                    var midPoint = (upperValue + lowerValue) / 2;

                    if (sequence[i] < smallest_value[midPoint])
                    {
                        upperValue = midPoint - 1;
                    }
                    else if (sequence[i] > smallest_value[midPoint])
                    {
                        lowerValue = midPoint + 1;
                    }
                }

                if (smallest_value[lowerValue] == 0)
                {
                    smallest_value[lowerValue] = sequence[i];
                    ++longestSubSeq;
                }
                else
                {
                    smallest_value[lowerValue] = Math.Min(smallest_value[lowerValue], sequence[i]);
                }
            }
            return longestSubSeq;
        }

        public static int solution(int[] A)
        {
            var boundary = 0;
            foreach (var a in A) if (a > boundary) boundary = a;
            ++boundary;

            var mv = new List<int>();

            // write your code in C# 6.0 with .NET 4.5 (Mono)
            foreach (var a in A)
            {
                mv.Add(boundary * 2 + a);
                mv.Add(boundary * 2 - a);
                mv.Add(a);
            }

            return GreaterSubSeq(mv);
        }
    }
}
