namespace Test
{
    class PermMissingElem
    {
        public static int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A.Length == 0) return 1;
            var result = 0;

            var temp = new int[A.Length + 1];

            foreach (var i in A)
            {
                temp[i - 1] = 1;
            }

            for (var i = 0; i < temp.Length; ++i)
            {
                if (temp[i] == 0)
                {
                    result = i + 1;
                    break;
                }
            }

            return result;
        }
    }
}
