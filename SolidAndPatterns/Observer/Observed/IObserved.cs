namespace Observer
{
    interface IObserved<T>
    {
        void Subscribe(Action<T> action);
        void Unsubscribe(Action<T> action);
        void Pump();
    }
}
