using DesignPatternsEntryPoint;
using SOLIDEntryPoint;

namespace SolidAndPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunSolidApp();
            RunDPApp();
        }

        static void RunSolidApp()
        {
            var app = new SolidApp();
            app.Run();
        }

        static void RunDPApp()
        {
            var app = new DPEntryPointApp();
            app.Run();
        }
    }
}
