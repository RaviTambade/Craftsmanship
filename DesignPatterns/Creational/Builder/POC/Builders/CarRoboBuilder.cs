namespace Transflower.DesignPatterns.Builder;
public class CarRoboBuilder:IBuilder{
    private Vehicle product=null;
    public void Reset(){
        this.product=new Vehicle();
        this.product.chassisnumber="654564";
        Console.WriteLine("auto Mode:Chassis is  ready");
    }
    public void SetSeats(int count){

        this.product.seats=count;
         Console.WriteLine("auto Mode:Seats are mounted");

    }
    public void SetEngine(Engine engine){
        this.product.engine=engine;
         Console.WriteLine("auto Mode:Engine is set up");

    }
    public void SetTripComputer(bool status){
        this.product.isTripComputer=status;
         Console.WriteLine("auto Mode:Trip computer set up");
    }
    public void SetGPS(bool status){
        this.product.gps=status;
         Console.WriteLine("auto Mode:GPS is set Up");
    }
    public Vehicle GetProduct(){
       // this.reset();
        return product;
    }
}