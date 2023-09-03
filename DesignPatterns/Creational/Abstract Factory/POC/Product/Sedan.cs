namespace Transflower.DesignPattern.AbstractFactory;

class Sedan : ICar
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