namespace Transflower.DesignPatterns.State;

class TrafficLight
{
    private Color _color = null;

    public TrafficLight(Color color)
    {
        TransitionTo(color);
    }

    public void TransitionTo(Color color)
    {
        _color = color;
        _color.SetLight(this);
    }

    public void ChangeSignal()
    {
        _color.ChangeColor();
    }
}
