namespace Transflower.DesignPatterns.State;

class YellowColor : Color
{
    public override void ChangeColor()
    {
       Console.WriteLine("Traffic light is now Yellow");
        this._light.TransitionTo(new RedColor());
    }
}