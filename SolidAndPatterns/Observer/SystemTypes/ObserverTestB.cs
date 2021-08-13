namespace Observer
{
    class ObserverTestB : System.IObserver<int>
    {
        IObservable<int> _provider;
        IDisposable _unsubscriber;

        public ObserverTestB(IObservable<int> provider)
        {
            _provider = provider;
            _unsubscriber = _provider.Subscribe(this);
        }

        public void OnCompleted()
        {
            Console.WriteLine("Value is 0. We are DONE >.<");
            _unsubscriber.Dispose();
        }

        public void OnError(Exception error)
        {
            // Not used
        }

        public void OnNext(int value)
        {
            Console.WriteLine($"Amazing! Scored {value}.");
        }
    }
}
