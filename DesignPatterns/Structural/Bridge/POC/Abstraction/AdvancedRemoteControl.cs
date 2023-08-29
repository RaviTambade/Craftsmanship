namespace Transflower.Abstraction.RemoteControls;
using  Transflower.Implementation.Devices;
public class AdvancedRemoteControl:RemoteControl{
    public AdvancedRemoteControl(IDevice device):base(device){
       // _device=device;
    }
    public void Mute(){
        _device.Volume=0;
    }
}