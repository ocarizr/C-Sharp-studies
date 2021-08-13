namespace Observer
{
    interface IObserver<T>
    {
        void Run(T data);
    }
}
