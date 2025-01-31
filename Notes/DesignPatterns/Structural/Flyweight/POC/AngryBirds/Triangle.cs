namespace Transflower.DesignPatterns.Strucutural.Flyweight.POC.AngryBirds;

// ConcreteFlyweight
    // This is a class which is Inherits from the Flyweight Interface.
public class Triangle : IShape
{
    public string Color { get; set; }
    //The following Properties Values are going to be the same for all Circle Shape Object
    private readonly int XCor = 10;
    private readonly int YCor = 20;
    private readonly int Height = 15;
    private readonly int Width = 30;

    //For Each Circle Object, we need to call the Following Method to set the Color
    public void SetColor(string Color)
    {
        this.Color = Color;
    }
    public void Draw()
    {
        Console.WriteLine(" Circle: Draw() [Color : " + Color + ", X Cor : " + XCor + ", YCor :" + YCor + ", Height :" + Height +",Width :" + Width);
    }

}