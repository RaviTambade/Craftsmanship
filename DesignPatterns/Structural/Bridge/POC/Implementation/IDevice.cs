namespace Transflower.Implementation.Devices;
public interface IDevice{ 
    int Volume{get;set;}
    int Channel{get;set;}
    bool IsEnable();
    void Enable();
    void Disable();
}