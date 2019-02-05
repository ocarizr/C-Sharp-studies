namespace CursoCSharp_P1
{
    class ClassExercise
    {
        public bool ConditionResult = false;

        public void MinorThanTen(int a) // return if a is minor than 10
        {
            if (a >= 10)
            {
                ConditionResult = false;
                return;
            }

            ConditionResult = true;
        }

        public void Greater(int a, int b) // return if a is greater than b
        {
            if (a < b)
            {
                ConditionResult = false;
                return;
            }

            ConditionResult = true;
        }

        public static bool InvertResult(bool a) // Return the oposite of the input (Logic port NOT)
        {
            return !a;
        }

        public override string ToString()
        {
            return $"The last result obtained is {ConditionResult}.";
        }
    }
}
