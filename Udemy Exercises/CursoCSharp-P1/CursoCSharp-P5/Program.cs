using System;

namespace CursoCSharp_P5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Matrix Main Diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();
            int countNegative = 0;

            foreach(int i in mat)
            {
                if (i < 0)
                {
                    countNegative++;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Ammount of negative numbers: {countNegative}.");
        }
    }
}
