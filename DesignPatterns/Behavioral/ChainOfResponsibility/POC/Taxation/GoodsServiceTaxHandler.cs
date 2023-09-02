using Transflower.DesignPatterns.ChainOfResponsibility;

public class GoodsServiceTaxHandler : TaxHandler
    {
        public override object Deduct(object request)
        {
            if (request.ToString() == "Laptop")
            {
                return $"GoodServiceTax Deducted:  {request.ToString()}.\n";
            }
            else
            {
                return base.Deduct(request);
            }
        }
    }