namespace  Transflower.DesignPatterns.Observer;

public class EmailSubscriber:ISubscriber{
    public void Update(){
        Console.WriteLine( "Email is sent to customer.....");
    }
}