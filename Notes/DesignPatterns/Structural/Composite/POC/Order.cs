using System.Collections.Generic;
namespace Transflower.Composite.OrderProcessing;
public class Order
{
    private List<Item> _items = new List<Item>();

    public void Add(Item item)
    {
        _items.Add(item);
    }

    public void Remove(Item item)
    {
        _items.Remove(item);
    }

    public double GetTotalAmount()
    {
        double amount = 0;
        foreach (Item item in _items)
        {
            amount = amount + item.GetTotalAmount();
        }
        return amount;
    }
}