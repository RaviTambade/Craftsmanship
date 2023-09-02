namespace Transflower.DesignPatterns.Iterator;
using System.Collections.Generic;
public class VehicleList : IVehicleList
{
    private List<Vehicle> vehicles = new List<Vehicle>();

    public void AddVehicle(Vehicle vehicle)
    {
        vehicles.Add(vehicle);
    }

    public IIterator<Vehicle> CreateIterator()
    {
        return new VehicleIterator(vehicles);
    }
}
