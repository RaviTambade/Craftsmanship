using Transflower.DesignPatterns.ChainOfResponsibility;
public class MetroTaxHandler : TaxHandler
{
    public override object Deduct(object request)
    {
        if ((request as string) == "PuneMetro")
        {
            return $"Metro Infrastructure Tax Deducted:  {request.ToString()}.\n";
        }
        else
        {
            return base.Deduct(request);
        }
    }
}