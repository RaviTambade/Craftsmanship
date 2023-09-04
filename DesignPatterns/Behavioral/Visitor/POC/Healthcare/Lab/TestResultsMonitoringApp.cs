using System.Collections.Generic;

using Transflower.DesignPatterns.Visitor.Healthcare.Contracts;


    public class TestResultsMonitoringApp
    {
        private readonly List<ISicknessAlertVisitor> _detectors;

        public TestResultsMonitoringApp(List<ISicknessAlertVisitor> detectors)
        {
            _detectors = detectors;
        }

        public List<AlertReport> AnalyzeResultsBatch(IEnumerable<ISicknessAlertVisitable> testResults)
        {
            var alertReports = new List<AlertReport>();

            foreach (var sample in testResults)
            {
                foreach (var detector in _detectors)
                {
                    alertReports.Add(sample.Accept(detector));
                }
            }
            return alertReports;
        }
    }
