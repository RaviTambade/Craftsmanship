namespace Transfolwer.DesignPattern.Facade;
public interface IOrderProcessor {
     void PlaceOrder(string product, int quantity, double amount, string address);
}