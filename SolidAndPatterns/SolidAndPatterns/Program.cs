using SingleResponsibilityPrinciple;
using OpenClosePrinciple;
using LiskovSubstitutionPrinciple;
using InterfaceSegregationPrinciple;

namespace SolidAndPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // RunSRPApp();
            // RunOCPApp();
            // RunLSPApp();
            RunISPApp();
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

        static void RunISPApp()
        {
            var app = new ISPApp();
            app.Run();
        }
    }
}
