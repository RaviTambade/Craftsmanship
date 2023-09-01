namespace Transflower.DesignPatterns.Builder;

public class Vehicle{
    public string title;
    public Engine engine;
    public int seats;
    public string chassisnumber; 
    public  bool isTripComputer;
    public  bool gps;
    public Vehicle(){
        this.seats=0;
    }
    public override string ToString()
    {
        string title="Vehicle: "+ this.title;
        string chassis= "Chassis No: "+ this.chassisnumber; 
        string engine= "Engine: "+  GetEngineTypeName(this.engine);
        string seats= "No. Of Seat: "+ this.seats;
        string gps= "GPS: "+ this.gps;
        string tripComputer="Trip Computer: "+ this.isTripComputer;
        string str=title+ "\n" +chassis + "\n"+ engine + "\n" + seats + "\n"+ gps +
                "\n"+ tripComputer;
        return str;
    }

    public string GetEngineTypeName(Engine engine){
        Type type=engine.GetType();
        Console.WriteLine(type.Name);
        return type.Name;
    }
}