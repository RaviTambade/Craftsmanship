namespace Transflower.DesignPattern.AbstractFactory;


class SedanFactory : ICarFactory
{
    public ICar CreateCar()
    {
        return new Sedan();
    }
}

