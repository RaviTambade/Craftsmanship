namespace Transflower.DesignPatterns.Iterator;
public class Traveller : Transport
{
    public int Seats { get; set; }
    public Traveller(string rtoNo, string make, string model, int year, int seats)
        : base(rtoNo,make, model, year)
    {
        Seats = seats;
    }
}
