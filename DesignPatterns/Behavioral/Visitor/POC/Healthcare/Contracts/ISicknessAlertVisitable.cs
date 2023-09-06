namespace Transflower.DesignPatterns.Visitor.Healthcare.Contracts;

public interface ISicknessAlertVisitable{
    AlertReport Accept(ISicknessAlertVisitor visitor);
    
}