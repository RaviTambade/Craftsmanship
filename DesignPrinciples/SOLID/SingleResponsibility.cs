namespace Transflower.DesignPrinciples.SOILD.SingleResponsibility;

public interface ICustomer
{
    void SaveCustomerRecord();
    void ValidateCustomer();
}
public interface IOrder
{
    void PrintOrder();
}
public class Customer: ICustomer
{
    // Properties
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    // Methods
    public void SaveCustomerRecord()
    {
        // Code to save the customer's information to a database
    }

    public void ValidateCustomer()
    {
        // Code to validate the customer's information before saving
    }
}
public class Order: IOrder
{
    public void PrintOrder()
    {
        // Code to print an invoice for the customer Order
    }
}