namespace Transflower.DesignPattern.AbstractFactory;

class SUVFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new SUV();
    }
}