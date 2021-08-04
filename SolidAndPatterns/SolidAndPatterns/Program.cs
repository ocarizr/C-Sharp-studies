using SingleResponsibilityPrinciple;
using OpenClosePrinciple;

namespace SolidAndPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunSRPApp();
            RunOCPApp();
        }

        static void RunSRPApp()
        {
            var app = new SRPApp();
            app.Run();
        }

        static void RunOCPApp()
        {
            var app = new OCPApp();
            app.Run();
        }
    }
}
