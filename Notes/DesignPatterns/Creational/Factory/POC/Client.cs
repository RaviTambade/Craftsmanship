namespace Transflower.Logistics;
public class Client{
    
    public void Main()
    {
        Console.WriteLine("App: Launched with the RoadLogistic.");
        ClientCode(new RoadLogistic());

        Console.WriteLine("");

        Console.WriteLine("App: Launched with the SeaLogistic.");
        ClientCode(new SeaLogistic());
    }

    // The client code works with an instance of a concrete creator, albeit
    // through its base interface. As long as the client keeps working with
    // the creator via the base interface, you can pass it any creator's
    // subclass.
    public void ClientCode(Logistics logistics)
    {
        // ...
        Console.WriteLine("Client: I'm not aware of the creator's class," +
            "but it still works.\n" + logistics.PlanDelivery());
        // ...
    }
}
