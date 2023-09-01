
using Transflower.DesignPatterns.ChainOfResponsibility;
public class IncomeTaxHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        if ((request as string) == "Salary")
        {
            return $"Income Tax: I'll eat the {request.ToString()}.\n";
        }
        else
        {
            return base.Handle(request);
        }
    }
}