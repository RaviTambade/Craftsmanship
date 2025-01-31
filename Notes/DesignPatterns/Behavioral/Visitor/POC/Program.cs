using System;
using System.Collections.Generic;
using Transflower.DesignPatterns.Visitor.Healthcare.Contracts;
using Transflower.DesignPatterns.Visitor.Healthcare.Detectors;

namespace Transflower.DesignPatterns.Visitor
{
    public class Program
    {
        public static void Main(string[] args)
        {
           /* // Setup employee collection

            Employees employee = new Employees();
            employee.Attach(new Clerk());
            employee.Attach(new Director());
            employee.Attach(new President());

            // Employees are 'visited'

            employee.Accept(new IncomeVisitor());
            employee.Accept(new VacationVisitor());

            // Wait for user

            Console.ReadKey();
            */

            //arrange
            var testResults = new List<ISicknessAlertVisitable>() { new BloodSample(), new XRayImage(), new EcgReading() };
            var detectors = new List<ISicknessAlertVisitor>() { new CancerDetector(), new HivDetector() };
            var monitor = new TestResultsMonitoringApp(detectors);
            monitor.AnalyzeResultsBatch(testResults);
            
        }
    }    
}
