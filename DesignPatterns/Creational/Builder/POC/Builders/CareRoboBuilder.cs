namespace Transflower.DesignPatterns.Builder;
public class CarRoboBuilder:IBuilder{
    private Car product=null;
    public void reset(){
        this.product=new Car();
        this.product.chassisnumber="654564";
        Console.WriteLine("Body is set for Assembly :Auto Mode");
    }
    public void setSeats(int count){
        this.product.seats=count;
        Console.WriteLine("Auto Mode: {0} seats are attached");
    }
    public void setEngine(Engine engine){
        this.product.engine=engine;
        Console.WriteLine("Auto Mode: Engine is set up on vehicle");
    }
    public void setTripComputer(bool status){
        this.product.isTripComputer=status;
        Console.WriteLine("Auto Mode : Computer is triped for vechile");
    }
    public void setGPS(bool status){
        this.product.gps=status;
        Console.WriteLine("Auto Mode: GPS is  configured  for vehicle");
    }
    public Car GetProduct(){
        this.reset();
        return product;
    }
}