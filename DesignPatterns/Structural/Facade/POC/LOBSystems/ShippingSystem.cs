namespace Transfolwer.DesignPattern.Facade;

class ShippingSystem
{
    public void Ship(string product, string address)
    {
        Console.WriteLine($"Shipped :{product} to :{address}");
    }
}