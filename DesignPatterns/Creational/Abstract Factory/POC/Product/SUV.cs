namespace Transflower.DesignPattern.AbstractFactory;

class SUV : ICar
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