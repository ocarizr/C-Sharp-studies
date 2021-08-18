namespace Observer
{
    class ObserveInt : IObserved<int>
    {
        private Action<int>? _action;
        private Random _random = new Random(DateTime.Now.Millisecond);

        public void Pump()
        {
            if (_action is null)
            {
                return;
            }

            var result = _random.Next(1, 10000);
            if (result > 9000)
            {
                _action.Invoke(result % 9000);
                Thread.Sleep(1);
            }
        }

        public void Subscribe(Action<int> action)
        {
            if (_action is null)
            {
                _action = action;
                return;
            }

            _action += action;
        }

        public void Unsubscribe(Action<int> action)
        {
            if (_action is { })
            {
                _action -= action;
            }
        }
    }
}