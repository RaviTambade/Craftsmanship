namespace Transflower.DesignPatterns.Iterator;
public interface IVehicleList
{
    void AddVehicle(Vehicle vehicle);
    IIterator<Vehicle> CreateIterator();
}
