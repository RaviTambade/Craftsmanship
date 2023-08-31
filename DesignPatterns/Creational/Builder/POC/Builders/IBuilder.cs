namespace Transflower.DesignPatterns.Builder;
public interface IBuilder{
    void reset();
    void setSeats(int count);
    void setEngine(Engine engine);
    void setTripComputer(bool status);
    void setGPS(bool status);

    Car GetProduct();

}