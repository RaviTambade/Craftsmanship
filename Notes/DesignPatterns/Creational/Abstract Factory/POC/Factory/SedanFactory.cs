namespace Transflower.DesignPattern.AbstractFactory;


class SedanFactory : IAutomobileFactory
{
    public IVehicle CreateCar()
    {
        return new Sedan();
    }
}

