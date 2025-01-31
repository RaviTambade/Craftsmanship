namespace Transflower.DesignPatterns.Visitor.Healthcare.Contracts;

public interface ISicknessAlertVisitor{

    AlertReport Visit(BloodSample blood);
    AlertReport Visit(XRayImage image);
    AlertReport Visit(EcgReading ecg);

}