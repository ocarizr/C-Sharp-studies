using Decorator;
using Observer;
using Strategy;

namespace DesignPatternsEntryPoint
{
    public class DPEntryPointApp
    {
        public void Run()
        {
            // RunStrategyApp();
            // RunObserverApp();
            RunDecoratorApp();
        }

        private void RunStrategyApp()
        {
            var app = new StrategyApp();
            app.Run();
        }

        private void RunObserverApp()
        {
            var app = new ObserverApp();
            app.Run();
        }

        private void RunDecoratorApp()
        {
            var app = new DecoratorApp();
            app.Run();
        }
    }
}
