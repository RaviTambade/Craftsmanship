
using Transflower.DesignPatterns.ChainOfResponsibility;
public class IncomeTaxHandler : TaxHandler
{
    public override object Deduct(object request)
    {
        if ((request as string) == "Salary")
        {
            return $"Income Tax: Deducted {request.ToString()}.\n";
        }
        else
        {
            return base.Deduct(request);
        }
    }
}