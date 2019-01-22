using System;

namespace ConsoleApp2
{
    class Solution
    {
        public int solution(int[] A)
        {
            int crossingPlanes = 0;

            for (int i = 0; i < A.Length - 1; i++)
            {
                if ((A[i]) == 0)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[j] == 1)
                        {
                            crossingPlanes++;
                        }
                    }
                }
            }

            if (crossingPlanes > 1000000000)
            {
                return -1;
            }

            return crossingPlanes;
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            Console.Write("In how many parts was the route divided? ");
            int a = int.Parse(Console.ReadLine());
            int[] A = new int[a];
            Console.WriteLine("Now fill with 0 (to NW-L) and 1 (to L-NW) each slice of the road:");
            for (int i = 0; i < a; i++)
            {
                Console.Write("Plane on the part " + i + " of the route: ");
                A[i] = int.Parse(Console.ReadLine());

                if (A[i] < 0 || A[i] > 1)
                {
                    i--;
                }
            }

            Console.WriteLine("There are " + s.solution(A) + " pairs of crossing planes");

            Console.Read();
        }
    }
}
