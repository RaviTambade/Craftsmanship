using Transflower.DesignPatterns.ChainOfResponsibility;
   public class SalesTaxHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Soap")
            {
                return $"SalesTax: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }