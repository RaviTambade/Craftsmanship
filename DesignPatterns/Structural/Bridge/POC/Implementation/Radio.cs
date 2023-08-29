namespace Transflower.Implementation.Devices;
public class Radio:IDevice{
    
    private int _volume;
    private int _channel;
    
    //Properties are implemented 
    public int Volume
    {
        get{ return _volume;}
        set{_volume=value;}
    }

    public int Channel
    {
        get{ return _channel;}
        set{_channel=value;}
    }
    
    public bool IsEnable(){

        return false;
    }
    public void Enable(){

    }
    public void Disable(){

    }

}