namespace Transflower.DesignPatterns.State;

class RedColor : Color
{
    public override void ChangeColor()
    {
       Console.WriteLine("Traffic light is now Red");
       this._light.TransitionTo(new GreenColor());
    }
}