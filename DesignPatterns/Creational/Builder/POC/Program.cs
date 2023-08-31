using  Transflower.DesignPatterns.Builder;

Director director=new Director();
IBuilder builder=new CarRoboBuilder();

director.ConstructSportsCar(builder);
Car theCar=builder.GetProduct();
Console.WriteLine(theCar);
