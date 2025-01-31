namespace Transflower.DesignPattern.AbstractFactory;

class Sedan : IVehicle
{
    public string GetModel()
    {
        return "Sedan";
    }

    public string GetDescription()
    {
        return "A comfortable and fuel-efficient sedan car.";
    }
}