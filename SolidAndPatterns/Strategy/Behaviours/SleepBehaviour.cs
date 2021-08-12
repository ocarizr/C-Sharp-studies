namespace Strategy
{
    class SleepBehaviour : IBehaviour
    {
        public void Execute()
        {
            Console.WriteLine("Sleeping now.");
        }
    }
}
