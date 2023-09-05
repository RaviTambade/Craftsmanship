namespace Transflower.DesignPattern.AbstractFactory;

class SUVFactory : IAutomobileFactory
{
    public IVehicle CreateCar()
    {
        return new SUV();
    }
}