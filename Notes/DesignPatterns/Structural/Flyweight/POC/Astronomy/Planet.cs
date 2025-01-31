namespace Transflower.DesignPatterns.Strucutural.Flyweight.POC.Astronomy;
public class Planet : IGalaxy
{
    public static Ellipse StarShape = new Ellipse(30, 30, "red"); // Intrinsic State

    // These are the extrinsic states
    int positionX;
    int positionY;
    double brightness;

    public void SetBrightness(double brightness)
    {
        this.brightness = brightness;
    }

    public void SetPosition(int x, int y)
    {
        positionX = x;
        positionY = y;
    }

    public override string ToString()
    {
        return string.Format($"A Planet at located at [{positionX},{positionY}] coordinate and is having a brigtness of [{brightness}]%");
    }
}