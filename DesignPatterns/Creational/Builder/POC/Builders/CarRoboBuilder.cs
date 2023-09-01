namespace Transflower.DesignPatterns.Builder;
public class CarRoboBuilder:IBuilder{
    private Car product=null;
    public void reset(){
        this.product=new Car();
        this.product.chassisnumber="654564";
        Console.WriteLine("auto Mode:Chassis is  ready");
    }
    public void setSeats(int count){

        this.product.seats=count;
         Console.WriteLine("auto Mode:Seats are mounted");

    }
    public void setEngine(Engine engine){
        this.product.engine=engine;
         Console.WriteLine("auto Mode:Engine is set up");

    }
    public void setTripComputer(bool status){
        this.product.isTripComputer=status;
         Console.WriteLine("auto Mode:Trip computer set up");
    }
    public void setGPS(bool status){
        this.product.gps=status;
         Console.WriteLine("auto Mode:GPS is set Up");
    }
    public Car GetProduct(){
       // this.reset();
        return product;
    }
}