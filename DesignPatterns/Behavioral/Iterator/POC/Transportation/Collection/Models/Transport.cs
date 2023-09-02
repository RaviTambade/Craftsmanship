namespace Transflower.DesignPatterns.Iterator;
public class Transport
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string RTONo{get;set;}

    public Transport(string rtoNo,string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        RTONo=rtoNo;
    }
}
