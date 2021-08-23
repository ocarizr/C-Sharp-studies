using AppBase;
using DependencyInversionPrinciple;
using DontRepeatYourself;
using InterfaceSegregationPrinciple;
using LiskovSubstitutionPrinciple;
using OpenClosePrinciple;
using SingleResponsibilityPrinciple;

namespace SOLIDEntryPoint
{
    public class SolidApp : IApp
    {
        enum SolidAppType
        {
            SRP,
            OCP,
            LSP,
            ISP,
            DIP,
            DRY
        }

        public void Run()
        {
            GetApp(SolidAppType.DRY).Run();
        }

        private IApp GetApp(SolidAppType app) => app switch
        {
            SolidAppType.SRP => new SRPApp(),
            SolidAppType.OCP => new OCPApp(),
            SolidAppType.LSP => new LSPApp(),
            SolidAppType.ISP => new ISPApp(),
            SolidAppType.DIP => new DIPApp(),
            SolidAppType.DRY => new DRYApp(),
            _ => throw new Exception("Invalid SolidApp type"),
        };
    }
}
