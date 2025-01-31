
namespace Transfolwer.DesignPattern.Facade;
class PaymentSystem
{
    public void Process(double amount)
    {
        Console.WriteLine($"Processed payment of :{amount}");
    }
}
