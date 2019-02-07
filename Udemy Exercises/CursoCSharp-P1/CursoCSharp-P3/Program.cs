using System;
using System.Globalization;

namespace CursoCSharp_P3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nullable Exercise:");
            Console.WriteLine();
            NullableExercise();

            WaitAndClear();

            Console.WriteLine("Array Exercise:");
            Console.WriteLine();
            ArrayExercise();

            WaitAndClear();
            
            Console.WriteLine("Array Exercise 2:");
            Console.WriteLine();
            ArrayExercise2();

            WaitAndClear();
            
            Console.WriteLine("Array Exercise 3:");
            Console.WriteLine();
            ArrayExerciseClass ae = new ArrayExerciseClass();
        }

        public static void WaitAndClear()
        {
            Console.ReadLine();
            Console.Clear();
        }

        public static void NullableExercise()
        {
            double? x = null;
            double? y = 10.0;

            double a = x ?? 5.0;
            double b = y ?? 5.0;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.WriteLine();

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine();

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null.");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("X is null.");
            }
        }

        public static void ArrayExercise()
        {
            Console.Write("Size of the array: ");
            int size = int.Parse(Console.ReadLine());
            double[] n = new double[size];

            Console.WriteLine();
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write($"Input the value for the slot {i+1} of the array: ");
                n[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine();
            double sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine($"n[{i}] = {n[i].ToString("F2", CultureInfo.InvariantCulture)}");
                sum += n[i];
            }

            Console.WriteLine();
            Console.WriteLine($"The sum of all the numbers in the array is {sum.ToString("F2", CultureInfo.InvariantCulture)}");

            double average = sum / n.Length;

            Console.WriteLine();
            Console.WriteLine($"The Average of the numbers in the array is {average.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public static void ArrayExercise2()
        {
            Console.Write("Size of the array of products: ");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Product[] p = new Product[size];
            double sum = 0;
            for(int i = 0; i < p.Length; i ++)
            {
                Console.Write($"Type the name of the product {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Type the price of this product: $");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p[i] = new Product(name, price);
                sum += p[i].Price;
                Console.WriteLine();
            }

            Console.WriteLine("The Average price is ${0}", (sum/size).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
