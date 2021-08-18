namespace Observer
{
    class Unsubscriber<T> : IDisposable
    {
        private List<System.IObserver<T>> _observers;
        private System.IObserver<T> _observer;

        public Unsubscriber(List<System.IObserver<T>> observers, System.IObserver<T> observer)
        {
            _observers = observers;
            _observer = observer;
        }

        public void Dispose()
        {
            if (_observers is { })
            {
                _observers.Remove(_observer);
            }
        }
    }
}