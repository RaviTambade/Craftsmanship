﻿using Transflower.DesignPatterns.Visitor.Healthcare.Contracts;

namespace Transflower.DesignPatterns.Visitor.Healthcare.Detectors
{
    public class HivDetector : ISicknessAlertVisitor
    {
        public AlertReport Visit(BloodSample blood)
        {
            Console.WriteLine($"{GetType().Name} - Checking blood sample");
            //analyze the blood and return correct risk value
            return AlertReport.LowRisk;
        }
        public AlertReport Visit(XRayImage rtg)
        {
            Console.WriteLine($"{GetType().Name} - currently cannot detect HIV based on X-Ray");
            return AlertReport.NotAnalyzable;
        }
        public AlertReport Visit(EcgReading sample)
        {
            Console.WriteLine($"{GetType().Name} - Checking ECG");
            return AlertReport.HighRisk;
        }
    }
}