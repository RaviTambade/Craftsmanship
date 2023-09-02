namespace Transflower.DesignPatterns.Builder;
public class CarMannualBuilder:IBuilder{
    private Vehicle product;
   public void Reset(){
        Console.WriteLine("Body is set for Assembly :Mannual Mode");
    }
    public void SetSeats(int count){
        Console.WriteLine("Mannual Mode: {0} seats are attached");
    }
    public void SetEngine(Engine engine){

        Console.WriteLine("Mannual Mode: Engine is set up on vehicle");
    }
    public void SetTripComputer(bool status){
        Console.WriteLine("Mannual Mode : Computer is triped for vechile");
    }
    public void SetGPS(bool status){
        Console.WriteLine("Mannual Mode: GPS is  configured  for vehicle");
    }

     public Vehicle GetProduct(){
        this.Reset();
        return product;
    }
}

