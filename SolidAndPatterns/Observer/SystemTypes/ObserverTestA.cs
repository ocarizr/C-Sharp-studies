namespace Observer
{
    class ObserverTestA : System.IObserver<int>
    {
        IObservable<int> _provider;
        IDisposable _unsubscriber;

        public ObserverTestA(IObservable<int> provider)
        {
            _provider = provider;
            _unsubscriber = _provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Value is 0, so we completed :)");
            _unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            // Not used
        }

        public void OnNext(int value)
        {
            Console.WriteLine($"Obtained value {value}.");
        }
    }
}
