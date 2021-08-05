﻿using DependencyInversionPrinciple;
using InterfaceSegregationPrinciple;
using LiskovSubstitutionPrinciple;
using OpenClosePrinciple;
using SingleResponsibilityPrinciple;
using System;

namespace SOLIDEntryPoint
{
    public class SolidApp
    {
        public void Run()
        {
            // RunSRPApp();
            // RunOCPApp();
            // RunLSPApp();
            // RunISPApp();
            RunDIPApp();
        }

        private void RunSRPApp()
        {
            var app = new SRPApp();
            app.Run();
        }

        private void RunOCPApp()
        {
            var app = new OCPApp();
            app.Run();
        }

        private void RunLSPApp()
        {
            var app = new LSPApp();
            app.Run();
        }

        private void RunISPApp()
        {
            var app = new ISPApp();
            app.Run();
        }

        private void RunDIPApp()
        {
            var app = new DIPApp();
            app.Run();
        }
    }
}