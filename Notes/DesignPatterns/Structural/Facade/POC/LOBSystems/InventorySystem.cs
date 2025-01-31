namespace Transfolwer.DesignPattern.Facade;

public class InventorySystem
{
    public void Update(string product, int quantity)
    {
        Console.WriteLine($"Updated :{product}, quantity to :{quantity}");
    }
}