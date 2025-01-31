namespace Transflower.DesignPatterns.Builder;
 public class PetrolEngine:Engine{
     public override void Start()
    {
        Console.WriteLine(" Petrol Engine is started");
        
    }
    public override void Stop()
    {
        Console.WriteLine(" Petrol Engine is stopped");
    }
 }