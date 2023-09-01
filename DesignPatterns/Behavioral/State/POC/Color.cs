namespace Transflower.DesignPatterns.State;
 abstract class Color
{
    protected TrafficLight _light;
    public void SetLight(TrafficLight light)
    {
        _light = light;
    }

    public abstract void ChangeColor();

}
