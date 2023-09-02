namespace Transflower.DesignPatterns.Iterator;
public class Motorcycle : Vehicle
{
    public bool HasWindshield { get; set; }

    public Motorcycle(string make, string model, int year, bool hasWindshield)
        : base(make, model, year)
    {
        HasWindshield = hasWindshield;
    }
}
