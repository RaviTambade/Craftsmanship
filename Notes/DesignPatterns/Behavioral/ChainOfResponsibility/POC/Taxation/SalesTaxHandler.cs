using Transflower.DesignPatterns.ChainOfResponsibility;
   public class SalesTaxHandler : TaxHandler
    {
        public override object Deduct(object request)
        {
            if (request.ToString() == "Soap")
            {
                return $"SalesTax Deducted: {request.ToString()}.\n";
            }
            else
            {
                return base.Deduct(request);
            }
        }
    }