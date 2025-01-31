using  Transflower.Composite.OrderProcessing;
public class  Item{

    public Product TheProduct{get;set;}
    public int Quantity{get;set;}

    public double  GetTotalAmount(){
            double amount= (TheProduct.UnitPrice * Quantity) -this.TheProduct.Subsidy + TheProduct.SalesTax;
            return amount;
    }
}