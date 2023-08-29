namespace Transflower.DesignPatterns.Observer;

public class Publisher{
    public List<ISubscriber> _subscribers=new List<ISubscriber>();
    public void  Subscribe( ISubscriber  subscriber){
        _subscribers.Add(subscriber);
    }
    public void  UnSubscribe( ISubscriber  subscriber){
        _subscribers.Remove(subscriber);
    }

    public void Notify(){
        foreach(ISubscriber subscriber in _subscribers){
            subscriber.Update();
        }
    }

    public void BusinessLogic(){

    }
}
