namespace Transflower.DesignPatterns.Iterator;
public class Truck : Transport
{
    public int Axel { get; set; }

    public Truck(string rtoNo,string make, string model, int year, int axel)
        : base(rtoNo,make, model, year)
    {
        Axel = axel;
    }
}
