namespace Transflower.DesignPatterns.Iterator;
public class Car : Vehicle
{
    public int NumDoors { get; set; }

    public Car(string make, string model, int year, int numDoors)
        : base(make, model, year)
    {
        NumDoors = numDoors;
    }
}
