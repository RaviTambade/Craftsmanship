using  Transflower.Implementation.Devices;
using Transflower.Abstraction.RemoteControls;

Television television=new Television(4,5);
//RemoteControl remoteControl=new RemoteControl(television);
AdvancedRemoteControl remoteControl=new AdvancedRemoteControl(television);
remoteControl.TogglePower();
//remoteControl.Mute();
remoteControl.TogglePower();