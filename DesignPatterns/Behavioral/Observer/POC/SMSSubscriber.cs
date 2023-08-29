namespace Transflower.DesignPatterns.Observer;
public class SMSSubscriber:ISubscriber{

    public void Update(){
        Console.WriteLine( "Text message  is sent to customer  contact phone number.....");
    }
}