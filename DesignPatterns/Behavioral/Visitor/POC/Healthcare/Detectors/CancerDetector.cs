
using Transflower.DesignPatterns.Visitor.Healthcare.Contracts;

namespace Transflower.DesignPatterns.Visitor.Healthcare.Detectors
{
    public class CancerDetector : ISicknessAlertVisitor
    {
        public AlertReport Visit(BloodSample blood)
        {
            Console.WriteLine($"{GetType().Name} - Checking blood sample");
            return AlertReport.NotAnalyzable;
        }

        public AlertReport Visit(XRayImage rtg)
        {
            Console.WriteLine($"{GetType().Name} - Checking X-Ray");
            return AlertReport.NotAnalyzable;
        }

        public AlertReport Visit(EcgReading sample)
        {
            Console.WriteLine($"{GetType().Name} - Checking ECG");
            return AlertReport.NotAnalyzable;
        }
    }
}