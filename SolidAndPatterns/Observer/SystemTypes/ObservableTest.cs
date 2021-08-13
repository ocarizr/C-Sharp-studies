namespace Observer
{
    class ObservableTest : IObservable<int>
    {
        private List<System.IObserver<int>> _observers;
        private Random _random;

        public ObservableTest()
        {
            _observers = new List<System.IObserver<int>>();
            _random = new Random(DateTime.Now.Millisecond);
        }

        public IDisposable Subscribe(System.IObserver<int> observer)
        {
            _observers.Add(observer);
            return new Unsubscriber<int>(_observers, observer);
        }

        public void Pump()
        {
            if(_observers.Count == 0)
            {
                return;
            }

            var result = _random.Next(0, 10000);
            if (result > 9000)
            {
                foreach (var observer in _observers)
                {
                    observer.OnNext(result % 9000);
                }
                Thread.Sleep(1);
            }
            else if (result == 0)
            {
                for (int i = 0; i < _observers.Count;)
                {
                    var before = _observers.Count;
                    _observers[i].OnCompleted();
                    if(_observers.Count == before)
                    {
                        i++;
                    }
                }
            }
        }
    }
}
