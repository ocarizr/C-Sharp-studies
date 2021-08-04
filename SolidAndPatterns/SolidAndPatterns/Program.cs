using SingleResponsibilityPrinciple;
using OpenClosePrinciple;
using LiskovSubstitutionPrinciple;

namespace SolidAndPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunSRPApp();
            // RunOCPApp();
            RunLSPApp();
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

        static void RunLSPApp()
        {
            var app = new LSPApp();
            app.Run();
        }
    }
}
