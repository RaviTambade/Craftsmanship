namespace Transflower.Implementation.Devices;
public class Television:IDevice{
    
    private bool _status;
    private int _volume;
    private int _channel;
    
    public Television(){
        _channel=2;
        _volume=2;
    }
    public Television( int volume ,int channel){
        this._volume=volume;
        this._channel=channel;
    }
    //Properties are implemented 
    public int Volume
    {
        get{
             Console.WriteLine("Volume= "+ _volume); 
            return _volume;}
        set{
            _volume=value;
            Console.WriteLine("Volume= "+ _volume);
        }
    }

    public int Channel
    {
        get{ return _channel;}
        set{_channel=value;}
    }
    
    public bool IsEnable(){

        return _status;
    }
    public void Enable(){
        _status=true;
        Console.WriteLine(" Television is started...");

    }
    public void Disable(){
        _status=false;
        Console.WriteLine(" Television is switched off...");
    }

}