namespace Transflower.DesignPattern.AbstractFactory;

class SUV : IVehicle
{
    public string GetModel()
    {
        return "SUV";
    }

    public string GetDescription()
    {
        return "A spacious SUV with off-road capabilities.";
    }
}