using Strategy;

namespace DesignPatternsEntryPoint
{
    public class DPEntryPointApp
    {
        public void Run()
        {
            RunStrategyApp();
        }

        private void RunStrategyApp()
        {
            var app = new StrategyApp();
            app.Run();
        }
    }
}
