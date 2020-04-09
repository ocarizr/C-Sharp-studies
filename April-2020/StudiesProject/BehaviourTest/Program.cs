using System;

namespace BehaviourTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var t1 = new Task1();
            var t1_input = "abcd???ba";
            var t1_res = t1.solution(t1_input);
            Console.WriteLine(t1_res);

            var t2 = new Task2();
            int A = 15, B = 5;
            var t2_res = t2.solution(A, B);
            Console.WriteLine(t2_res);

            var t3 = new Task3();
            string s = "ABCDAA";
            var x = new int[] { 2 , 1, -2, 4, 3, 3};
            var y = new int[] { 2 , 2, 3, 4, -3, -3 };
            var t3_res = t3.solution(s, x, y);
            Console.WriteLine(t3_res);
        }
    }
}
