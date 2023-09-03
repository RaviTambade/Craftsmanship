using Transflower.DesignPattern.AbstractFactory;

ICarFactory sedanFactory = new SedanFactory();
ICar sedan = sedanFactory.CreateCar();

Console.WriteLine("Sedan Information:");
Console.WriteLine($"Model: {sedan.GetModel()}");
Console.WriteLine($"Description: {sedan.GetDescription()}");
Console.WriteLine();

// Create an SUV using SUVFactory
ICarFactory suvFactory = new SUVFactory();
ICar suv = suvFactory.CreateCar();

Console.WriteLine("SUV Information:");
Console.WriteLine($"Model: {suv.GetModel()}");
Console.WriteLine($"Description: {suv.GetDescription()}");