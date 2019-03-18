using System;
using System.Collections.Generic;

namespace VanHackChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            NodesChallengeOne();
            NodesChallengeTwo();
        }

        public static void NodesChallengeOne()
        {
            int gNodes = 7;
            List<int> gFrom = new List<int>();
            List<int> gTo = new List<int>();

            gFrom.Add(1);
            gFrom.Add(4);
            gFrom.Add(4);
            gFrom.Add(5);
            gFrom.Add(5);

            gTo.Add(2);
            gTo.Add(5);
            gTo.Add(6);
            gTo.Add(6);
            gTo.Add(7);

            int result = Result.MaximumDifference(gNodes, gFrom, gTo);

            Console.WriteLine(result);
        }

        public static void NodesChallengeTwo()
        {
            List<int> parent = new List<int>();
            List<int> values = new List<int>();

            parent.Add(-1);
            parent.Add(0);
            parent.Add(1);
            parent.Add(2);
            parent.Add(0);

            values.Add(-2);
            values.Add(10);
            values.Add(10);
            values.Add(-3);
            values.Add(10);

            int result = Result.bestSumAnyTreePath(parent, values);
            Console.WriteLine(result);
        }
    }
}
