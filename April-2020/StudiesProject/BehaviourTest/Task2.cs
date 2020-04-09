using System;
using System.Collections.Generic;

namespace BehaviourTest
{
    class Task2
    {
        public int solution(int A, int B)
        {
            if (A + B < 4) return 0;

            var biggerSide = 0;

            var longer = A > B ? A : B;
            var shorter = longer == A ? B : A;

            if (shorter == 1)
            {
                if (longer % 4 == 0) biggerSide = longer / 4;
                else biggerSide = 1;
            }
            else
            {
                if (longer / 4 > shorter) biggerSide = longer / 4;
                else if (longer / 3 <= shorter && longer / 3 > shorter / 2) biggerSide = longer / 3;
                else biggerSide = shorter / 2;
            }

            return biggerSide;
        }
    }
}
