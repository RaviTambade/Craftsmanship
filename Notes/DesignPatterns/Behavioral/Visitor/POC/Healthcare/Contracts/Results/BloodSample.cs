namespace Transflower.DesignPatterns.Visitor.Healthcare.Contracts;

public class BloodSample:ISicknessAlertVisitable{
    public AlertReport Accept(ISicknessAlertVisitor visitor)=>visitor.Visit(this);
}
