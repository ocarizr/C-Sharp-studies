using AppBase;

namespace Observer
{
    public class ObserverApp : IApp
    {
        public void Run()
        {
            // My types
            Console.WriteLine("My Types");
            Console.WriteLine();

            var observed = new ObserveInt();
            var observer = new IntListener();
            var observer2 = new DifferentIntListener();
            observed.Subscribe(observer.Run);
            observed.Subscribe(observer2.Run);
            for (int i = 0; i < 1000; i++)
            {
                // With subscribers it will observe the random number generation
                observed.Pump();
            }

            observed.Unsubscribe(observer.Run);
            observed.Unsubscribe(observer2.Run);

            // System types

            Console.WriteLine();
            Console.WriteLine("System namespace Types");
            Console.WriteLine();

            var provider = new ObservableTest();
            var obA = new ObserverTestA(provider);
            var obB = new ObserverTestB(provider);
            for (int i = 0; i < 1000; i++)
            {
                provider.Pump();
            }
        }
    }
}
