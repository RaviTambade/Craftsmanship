using Transflower.DesignPattern.AbstractFactory;

<<<<<<< HEAD
IAutomobileFactory sedanFactory = new SedanFactory();
IVehicle sedan = sedanFactory.CreateCar();
=======
ICarFactory factory1 = new SedanFactory();
ICar sedan = factory1.CreateCar();
>>>>>>> 34570af3c47526ee95e845b59c32ad808bacd31a

Console.WriteLine("Sedan Information:");
Console.WriteLine($"Model: {sedan.GetModel()}");
Console.WriteLine($"Description: {sedan.GetDescription()}");
Console.WriteLine();

// Create an SUV using SUVFactory
<<<<<<< HEAD
ICarFactory suvFactory = new SUVFactory();
IVehicle suv = suvFactory.CreateCar();
=======
ICarFactory factory2 = new SUVFactory();
ICar suv = factory2.CreateCar();
>>>>>>> 34570af3c47526ee95e845b59c32ad808bacd31a

Console.WriteLine("SUV Information:");
Console.WriteLine($"Model: {suv.GetModel()}");
Console.WriteLine($"Description: {suv.GetDescription()}");