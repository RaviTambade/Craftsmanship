namespace Transflower.DesignPatterns.Strucutural.Flyweight.POC.Astronomy;
public class Star : IGalaxy
{

    //There is Intrinsic State
    public static Ellipse StarShape = new Ellipse(10, 10, "blue"); 
    
    // Intrinsic State
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
        return string.Format($"A Star at [{positionX},{positionY}] coordinate and is shining with [{brightness}]% brightness");
    }
}