using System;
using System.Collections.Generic;

namespace BehaviourTest
{
    class Task3
    {
        public int solution(string S, int[] X, int[] Y)
        {
            var points = new Dictionary<char, List<double>>();
            var repeated = new HashSet<char>();

            for (int i = 0; i < S.Length; ++i)
            {
                var radius = Math.Sqrt(Math.Pow(X[i], 2) + Math.Pow(Y[i], 2));

                if (points.ContainsKey(S[i]))
                {
                    points[S[i]].Add(radius);
                    repeated.Add(S[i]);
                }
                else
                {
                    var rads = new List<double>();
                    rads.Add(radius);
                    points.Add(S[i], rads);
                }
            }

            var lowerRadius = double.MaxValue;

            foreach (var r in repeated)
            {
                points[r].Sort();
                lowerRadius = Math.Min(lowerRadius, points[r][1]);
            }

            var pointInsideCircle = 0;

            foreach (var point in points.Values)
            {
                if (point[0] < lowerRadius) ++pointInsideCircle;
            }

            return pointInsideCircle;
        }
    }
}
