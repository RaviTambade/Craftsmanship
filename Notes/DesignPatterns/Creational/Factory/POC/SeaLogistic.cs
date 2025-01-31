namespace Transflower.Logistics;
public class SeaLogistic : Logistics
{
    public override ITransport CreateTransport()
    {
     return new Ship();
    }
}