namespace Transflower.DesignPatterns.State;

class GreenColor : Color
{
    public override void ChangeColor()
    {
        Console.WriteLine("Traffic light is now Green ");
        this._light.TransitionTo(new YellowColor());
    }
}
