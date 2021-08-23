using AppBase;
using DesignPatternsEntryPoint;
using SOLIDEntryPoint;

namespace SolidAndPatterns
{
    class Program
    {
        enum EntryPoints
        {
            Solid,
            DesignPattern
        }

        static void Main(string[] args)
        {
            GetApp(EntryPoints.DesignPattern).Run();
        }

        static IApp GetApp(EntryPoints app) => app switch
        {
            EntryPoints.Solid => new SolidApp(),
            EntryPoints.DesignPattern => new DPEntryPointApp(),
            _ => throw new Exception("Invalid EntryPoint")
        };
    }
}
