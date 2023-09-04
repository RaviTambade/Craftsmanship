 using System;

namespace Transflower.DesignPatterns.Command.Inventory;
 class Program
{
    static void Main(string[] args)
    {
        PriceModifier priceModifier = new PriceModifier();
        Product product = new Product("Phone", 500);

        Execute(product, priceModifier, new ProductCommand(product, PriceAction.Increase, 100));
           
        Execute(product, priceModifier, new ProductCommand(product, PriceAction.Increase, 50));

        Execute(product, priceModifier, new ProductCommand(product, PriceAction.Decrease, 25));

        Console.WriteLine(product);
    }

    private static void Execute(Product product, PriceModifier modifier, ICommand productCommand)
    {
        modifier.SetCommand(productCommand);
        modifier.Invoke();
    }
}