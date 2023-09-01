namespace Transflower.DesignPatterns.Builder;
 public class ElectricEngine:Engine{
    public override void Start()
    {
        Console.WriteLine(" Electric Engine is started");  
    }
    public override void Stop()
    {
        Console.WriteLine(" Electric Engine is stopped");
    }
 }