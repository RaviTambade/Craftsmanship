namespace Transflower.DesignPatterns.Visitor.Healthcare.Contracts;

public class XRayImage:ISicknessAlertVisitable{
    public AlertReport Accept(ISicknessAlertVisitor visitor)=>visitor.Visit(this);
}
