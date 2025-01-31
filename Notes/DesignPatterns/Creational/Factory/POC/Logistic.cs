namespace Transflower.Logistics;
public abstract class Logistics{
    public abstract ITransport CreateTransport();
    public string PlanDelivery(){
        var transport=CreateTransport();
        var result= "transport created successfully "
         + transport.Deliver();
        return result;
    }
}