using System;

namespace ConsoleApp1
{
    class Solution
    {
        public int solution (int X, int[] A)
        {
            int iSolution = 0;
            int[] x = new int[X];

            for (int i = 0; i < A.Length; i++)
            {
                x[A[i] - 1] = 1;

                for (int j = 0; j < x.Length; j++)
                {
                    iSolution += x[j];
                }
                if (iSolution == X)
                {
                    return i;
                }
                iSolution = 0;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.Write("The Number of Kilometers you want to be paved: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Now fill the number of months you want to schedule the work: ");
            int month = int.Parse(Console.ReadLine());
            int[] A = new int[month];
            for (int i = 0; i < month; i++)
            {
                Console.Write("Month number " + (i) + ": ");
                A[i] = int.Parse(Console.ReadLine());
                if (A[i] > X || A[i] < 1)
                {
                    i--;
                }
            }

            Console.WriteLine("Calculating the earliest month when the road will be completely paved...");
            Console.WriteLine("The road will be completely paved in month " + s.solution(X, A));

            Console.Read();
        }
    }
}
