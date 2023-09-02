namespace Transflower.DesignPatterns.Iterator;
using System.Collections.Generic;

public class VehicleIterator : IIterator<Vehicle>
{
    private List<Vehicle> vehicles;
    private int currentIndex = 0;

    public VehicleIterator(List<Vehicle> vehicles)
    {
        this.vehicles = vehicles;
    }

    public bool HasNext()
    {
        return currentIndex < vehicles.Count;
    }

    public Vehicle Next()
    {
        Vehicle vehicle = vehicles[currentIndex];
        currentIndex++;
        return vehicle;
    }
}
