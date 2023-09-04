using Transflower.DesignPattern.AbstractFactory;

ICarFactory factory1 = new SedanFactory();
ICar sedan = factory1.CreateCar();

Console.WriteLine("Sedan Information:");
Console.WriteLine($"Model: {sedan.GetModel()}");
Console.WriteLine($"Description: {sedan.GetDescription()}");
Console.WriteLine();

// Create an SUV using SUVFactory
ICarFactory factory2 = new SUVFactory();
ICar suv = factory2.CreateCar();

Console.WriteLine("SUV Information:");
Console.WriteLine($"Model: {suv.GetModel()}");
Console.WriteLine($"Description: {suv.GetDescription()}");