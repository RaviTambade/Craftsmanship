namespace Transfolwer.DesignPattern.Facade;
class OrderProcessingSystem :IOrderProcessor
{
    private readonly InventorySystem inventorySystem;
    private readonly PaymentSystem paymentSystem;
    private readonly ShippingSystem shippingSystem;

    public OrderProcessingSystem()
    {
        inventorySystem = new InventorySystem();
        paymentSystem = new PaymentSystem();
        shippingSystem = new ShippingSystem();
    }

    public void PlaceOrder(string product, int quantity, double amount, string address)
    {
        Console.WriteLine("Placing an order:");
        inventorySystem.Update(product, quantity);
        paymentSystem.Process(amount);
        shippingSystem.Ship(product, address);
        
        Console.WriteLine("Order placed successfully!");
    }
}