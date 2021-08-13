namespace Observer
{
    class DifferentIntListener : IObserver<int>
    {
        public void Run(int data)
        {
            Console.WriteLine($"This time I have a new message: Is over 9000!: {data + 9000}!");
        }
    }
}