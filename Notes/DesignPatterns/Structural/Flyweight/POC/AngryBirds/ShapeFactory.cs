namespace Transflower.DesignPatterns.Strucutural.Flyweight.POC.AngryBirds;

// FlyweightFacory
    // This is a factory class used to create concrete objects of the ConcreteFlyweight type
public class ShapeFactory
{
//The Following Dictionary is going to act as our Cache Memory
private static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();
//The following Method is going to return the Shape Object
public static IShape GetShape(string shapeType)
{
    IShape shape = null;
    if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
    {
        //If the key shapeType i.e. circle is stored in the Cache, then return the value of the key
        //else create circle object, store it in the Cache, and return the object
        if (shapeMap.TryGetValue("circle", out shape))
        {
        }
        else
        {
            shape = new Circle();
            shapeMap.Add("circle", shape);
            Console.WriteLine(" Creating circle object with out any color in shapefactory \n");
        }
    }
    return shape;
}

}