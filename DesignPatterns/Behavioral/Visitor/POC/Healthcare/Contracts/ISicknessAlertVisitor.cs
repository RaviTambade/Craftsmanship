namespace Transflower.DesignPatterns.Visitor.Healthcare.Contracts;

public interface ISicknessAlertVisitor{

    AlertReport Visit(BloodSample blood);
    AlertReport Visit(XRayImage blood);
    AlertReport Visit(EcgReading blood);

}