using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class BynaryGap
{
    public int solution(int N)
    {
        int max = 0;
        int countGap = 0;
        bool canStartCount = false;
        var nSize = sizeof(int) * 8;

        for (int i = 0; i < nSize; ++i)
        {
            if (((N >> i) & 0x1) == 1)
            {
                if (!canStartCount)
                    canStartCount = true;
                else
                {
                    max = Math.Max(countGap, max);
                    countGap = 0;
                }
            }
            else
            {
                if (canStartCount) ++countGap;
            }
        }

        return max;
    }
}
