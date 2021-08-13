namespace Observer
{
    internal class IntListener : IObserver<int>
    {
        public void Run(int data)
        {
            Console.WriteLine($"Value has changed to {data}.");
        }
    }
}