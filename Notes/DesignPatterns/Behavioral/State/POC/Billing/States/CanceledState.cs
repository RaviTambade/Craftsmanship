namespace Transflower.DesignPattern.State.Billing;
public class CanceledState : IInvoiceState
{
    public void Pay(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has been canceled and cannot be paid.");
    }

    public void Cancel(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has already been canceled and cannot be canceled again.");
    }

    public void Refund(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} has been canceled and cannot be refunded.");
    }
}
