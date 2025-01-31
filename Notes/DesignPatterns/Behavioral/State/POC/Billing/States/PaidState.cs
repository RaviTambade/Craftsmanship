namespace Transflower.DesignPattern.State.Billing;
public class PaidState : IInvoiceState
{
    public void Pay(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has already been paid.");
    }

    public void Cancel(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} cannot be cancelled.");
    }

    public void Refund(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has been refunded.");
    }
}