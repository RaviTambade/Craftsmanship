namespace Transflower.DesignPattern.State.Billing;

public class UnpaidState : IInvoiceState
{
    public void Pay(Invoice invoice)
    {
        Console.WriteLine($"Paying invoice {invoice.Number}...");

    }

    public void Cancel(Invoice invoice)
    {
        Console.WriteLine($"Canceling invoice {invoice.Number}...");

    }

    public void Refund(Invoice invoice)
    {
        Console.WriteLine($"Invoice {invoice.Number} is unpaid and cannot be refunded.");

    }
}