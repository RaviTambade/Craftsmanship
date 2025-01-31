namespace Transflower.DesignPatterns.Visitor.Healthcare.Contracts;

public class EcgReading:ISicknessAlertVisitable{
    public AlertReport Accept(ISicknessAlertVisitor visitor)=>visitor.Visit(this);
}
