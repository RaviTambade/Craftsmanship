namespace Transflower.DesignPatterns.Builder;
public interface IBuilder{
    void SetTitle();
    void Reset();
    void SetSeats(int count);
    void SetEngine(Engine engine);
    void SetTripComputer(bool status);
    void SetGPS(bool status);

    Vehicle GetProduct();

}