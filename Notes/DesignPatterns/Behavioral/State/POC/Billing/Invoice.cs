namespace Transflower.DesignPattern.State.Billing;
public class Invoice
{
    public int Number { get;}
    public decimal Amount { get;}
    public string Description{ get; }
    public IInvoiceState State{get; set;}

    public Invoice(int number, decimal amount, string description)
    {
        Number = number;
        Amount = amount;
        Description = description;

        // Set the invoice as Unpaid
        State = new UnpaidState();
    }


    public void Pay()
    {
        State.Pay(this);
        State = new PaidState();
    }

    public void Cancel()
    {
        State.Cancel(this);
        State = new CanceledState();
    }

    public void Refund()
    {
        State.Refund(this);
        State = new RefundedState();
    }
}