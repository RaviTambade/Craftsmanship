using Transflower.DesignPatterns.ChainOfResponsibility;

public class GoodsServiceTaxHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Laptop")
            {
                return $"GoodServiceTax: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }