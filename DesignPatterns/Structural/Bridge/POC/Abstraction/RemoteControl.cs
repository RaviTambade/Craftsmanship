namespace Transflower.Abstraction.RemoteControls;
using  Transflower.Implementation.Devices;
public class RemoteControl{
    protected IDevice _device;
    public RemoteControl(IDevice device){
        this._device=device;
    }

    public void TogglePower(){
        if(_device.IsEnable()){
            _device.Disable();
        }
        else{
            _device.Enable();
        }
    }
    public void VolumeDown(){
        _device.Volume--;
    }
    public void VolumeUp(){
        _device.Volume++;
    }
    public void ChannelDown(){ 
        _device.Channel--;
    }
    public void ChannelUp(){
        _device.Channel++;
    }
}