using SOLIDEntryPoint;

namespace SolidAndPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            RunSolidApp();
        }

        static void RunSolidApp()
        {
            var app = new SolidApp();
            app.Run();
        }
    }
}
