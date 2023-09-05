using Transflower.DesignPattern.AbstractFactory;

IAutomobileFactory sedanFactory = new SedanFactory();
IVehicle sedan = sedanFactory.CreateCar();

Console.WriteLine("Sedan Information:");
Console.WriteLine($"Model: {sedan.GetModel()}");
Console.WriteLine($"Description: {sedan.GetDescription()}");
Console.WriteLine();

// Create an SUV using SUVFactory
ICarFactory suvFactory = new SUVFactory();
IVehicle suv = suvFactory.CreateCar();

Console.WriteLine("SUV Information:");
Console.WriteLine($"Model: {suv.GetModel()}");
Console.WriteLine($"Description: {suv.GetDescription()}");