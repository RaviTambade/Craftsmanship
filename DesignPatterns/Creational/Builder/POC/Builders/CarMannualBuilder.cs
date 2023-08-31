namespace Transflower.DesignPatterns.Builder;
public class CarMannualBuilder:IBuilder{
    private Car product;
   public void reset(){
        Console.WriteLine("Body is set for Assembly :Mannual Mode");
    }
    public void setSeats(int count){
        Console.WriteLine("Mannual Mode: {0} seats are attached");
    }
    public void setEngine(Engine engine){

        Console.WriteLine("Mannual Mode: Engine is set up on vehicle");
    }
    public void setTripComputer(bool status){
        Console.WriteLine("Mannual Mode : Computer is triped for vechile");
    }
    public void setGPS(bool status){
        Console.WriteLine("Mannual Mode: GPS is  configured  for vehicle");
    }

     public Car GetProduct(){
        this.reset();
        return product;
    }
}

