using Decorator;
using FactoryMethod;
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
            // RunDecoratorApp();
            RunFactoryMethodApp();
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

        private void RunFactoryMethodApp()
        {
            var app = new FactoryMethodApp();
            app.Run();
        }
    }
}
