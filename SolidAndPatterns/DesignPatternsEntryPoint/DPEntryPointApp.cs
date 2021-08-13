using Observer;
using Strategy;

namespace DesignPatternsEntryPoint
{
    public class DPEntryPointApp
    {
        public void Run()
        {
            // RunStrategyApp();
            RunObserverApp();
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
    }
}
